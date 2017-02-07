using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailTrigger : MonoBehaviour {
    Vector2 position;

    void Start ()
    {
        position = new Vector2(4.604, -3.959);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ball")
        {
            Debug.Log("Reset ball posiion to start");
            other.transform.position = position;
            //other.transform.rotation = Vecotr3(0, 0, 0);
        }
    }
}
