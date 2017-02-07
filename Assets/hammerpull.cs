using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerpull : MonoBehaviour
{
    public GameObject hammer;
    Vector2 position;
    Vector2 newposition;
    float time;

	void Start ()
    {
        if (hammer == null)
            hammer = GameObject.FindWithTag("hammer");
        position = hammer.transform.position;
        newposition = position;
    }
	
	void Update ()
    {
        while (Input.GetKey(KeyCode.DownArrow))
        {
            time += Time.deltaTime;
        }
        newposition.y = position.y - time;
        hammer.transform.position = newposition;
    }
}
