using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    Rigidbody2D rigidBody;
    Vector2 currentPosition;
    Vector2 initialPosition;
    public GameObject ball;
    public static int score;

    void Start()
    {
        if (ball == null)
            ball = GameObject.FindWithTag("ball");

        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        initialPosition = gameObject.transform.position;
        score = 3;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ball")
        {
            gameObject.SetActive(false);
            score--;
        }
    }
    void Update()
    {
        currentPosition = initialPosition;
        currentPosition.x = initialPosition.x + Mathf.Sin(Time.timeSinceLevelLoad + 7.0f);
        rigidBody.MovePosition(currentPosition);
    }
}
