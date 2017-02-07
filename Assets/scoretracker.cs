using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoretracker : MonoBehaviour
{
    public static int score;
    public static GameObject stext;

    void Start ()
    {
        if (stext == null)
            stext = GameObject.FindWithTag("lives");
        score = 2;
    }
	
	void Update ()
    {
        
        stext.GetComponent<TextMesh>().text = "Score: " + score;
        Debug.Log("display score");
        if (score < 0)
        {
            stext.GetComponent<TextMesh>().text = "You win! Congrats m8! gg ez";
            Debug.Log("display you won message");
        }
    }
}
