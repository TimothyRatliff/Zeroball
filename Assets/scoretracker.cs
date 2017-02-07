using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoretracker : MonoBehaviour
{
    public static int score;
    public static GameObject stext;
    public GameObject enemy2;
    public GameObject enemy1;
    public GameObject enemy0;
    public GameObject winbox;

    void Start ()
    {
        if (stext == null)
            stext = GameObject.FindWithTag("score");
        score = 2;
    }
	
	void Update ()
    {
        if (enemy2.activeInHierarchy == true)
            score = 2;
        else if (enemy1.activeInHierarchy == true)
            score = 1;
        else if (enemy0.activeInHierarchy == true)
            score = 0;
        stext.GetComponent<TextMesh>().text = "Score: " + score;
        Debug.Log("display score");

        if (winbox.activeInHierarchy == true)
        {
            stext.GetComponent<TextMesh>().text = "You win! \nCongrats m8! \ngg ez";
            Debug.Log("display you won message");
        }
    }
}
