using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy0 : MonoBehaviour {
    Rigidbody2D rigidBody;
    Vector2 currentPosition;
    Vector2 initialPosition;
    public GameObject ball;
    public GameObject winbox;

    void Start()
    {
        if (ball == null)
            ball = GameObject.FindWithTag("ball");
        if (winbox == null)
            winbox = GameObject.FindWithTag("winbox");
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        initialPosition = gameObject.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ball")
        {
            winbox.SetActive(true);
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
