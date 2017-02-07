using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    Rigidbody2D rigidBody;
    Vector2 currentPosition;
    Vector2 initialPosition;
    public GameObject ball;
    public GameObject enemy0;

    void Start()
    {
        if (ball == null)
            ball = GameObject.FindWithTag("ball");
        if (enemy0 == null)
            enemy0 = GameObject.FindWithTag("enemy0");
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        initialPosition = gameObject.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ball")
        {
            enemy0.SetActive(true);
            gameObject.SetActive(false);
        }
    }
    void Update()
    {
        currentPosition = initialPosition;
        currentPosition.x = initialPosition.x + Mathf.Sin(Time.timeSinceLevelLoad + 7.0f);
        rigidBody.MovePosition(currentPosition);
    }
}
