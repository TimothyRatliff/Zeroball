using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour {
    Rigidbody2D rigidBody;
    Vector2 currentPosition;
    Vector2 initialPosition;
    public GameObject ball;
    public GameObject enemy1;
    public GameObject enemy0;
    public GameObject winbox;

    void Start()
    {
        if (ball == null)
            ball = GameObject.FindWithTag("ball");
        if (enemy1 == null)
            enemy1 = GameObject.FindWithTag("enemy1");
        if (enemy0 == null)
            enemy0 = GameObject.FindWithTag("enemy0");
        if (winbox == null)
            winbox = GameObject.FindWithTag("winbox");
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        initialPosition = gameObject.transform.position;
        enemy1.SetActive(false);
        enemy0.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ball")
        {
            enemy1.SetActive(true);
            gameObject.SetActive(false);
        }
    }
    void Update()
    {
        currentPosition = initialPosition;
        currentPosition.x = initialPosition.x + Mathf.Sin(Time.timeSinceLevelLoad + 35.0f);
        rigidBody.MovePosition(currentPosition);
    }
}
