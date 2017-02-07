using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailTrigger : MonoBehaviour {
    Vector2 initialPosition;
    public GameObject ball;
    public int lives;
    public GameObject ltext;

    void Start ()
    {
        if (ball == null)
            ball = GameObject.FindWithTag("ball");
        initialPosition = ball.transform.position;

        if (ltext == null)
            ltext = GameObject.FindWithTag("lives");
        lives = 5;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ball")
        {
            Debug.Log("Reset ball position to start");
            other.transform.position = initialPosition;
            lives--;
        }
    }
    void Update ()
    {
        ltext.GetComponent<TextMesh>().text = "Lives: " + lives;
        Debug.Log("display -1 life");
        if (lives == 0)
        {
            ltext.GetComponent<TextMesh>().text = "You lose! Try again next time.";
            Debug.Log("display you lost message");
        }
    }
}
