using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballspawntrigger : MonoBehaviour {
    public GameObject ball;
    public GameObject gate;

    void Start()
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
            Debug.Log("Ball has spawned, open gate");
            gate.SetActive(false);
        }
    }

}
