using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailTrigger : MonoBehaviour
{
    Vector2 initialPosition;
    public GameObject ball;
    public static int lives;
    public static GameObject ltext;
    public GameObject redx1;
    public GameObject redx2;

    void Start ()
    {
        if (ball == null)
            ball = GameObject.FindWithTag("ball");
        initialPosition = ball.transform.position;
        if (ltext == null)
            ltext = GameObject.FindWithTag("lives");
        if (redx1 == null)
            redx1 = GameObject.FindWithTag("redx");
        if (redx2 == null)
            redx2 = GameObject.FindWithTag("redx2");
        redx1.SetActive(false);
        redx2.SetActive(false);

        lives = 5;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ball")
        {
            if (lives >= 0)
            {
                Debug.Log("Reset ball position to start");
                other.transform.position = initialPosition;
            }
            lives--;
            if (lives < 0)
            {
                redx1.SetActive(true);
                redx2.SetActive(true);
            }
        }
    }
    void Update ()
    {
        ltext.GetComponent<TextMesh>().text = "Lives: " + lives;
        Debug.Log("display life");
        if (lives < 0)
        {
            ltext.GetComponent<TextMesh>().text = "You lose! Try again next time.";
            Debug.Log("display you lost message");
        }
    }
}
