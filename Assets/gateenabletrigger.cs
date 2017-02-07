using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateenabletrigger : MonoBehaviour
{
    public GameObject ball;
    public GameObject gate;

    void Start ()
    {
        if (ball == null)
            ball = GameObject.FindWithTag("ball");
        if (gate == null)
            gate = GameObject.FindWithTag("gate");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ball")
        {
            Debug.Log("Gate closed");
            gate.SetActive(true);
        }
    }
}
