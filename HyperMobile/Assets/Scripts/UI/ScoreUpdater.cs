using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    public Text scoreDisplay;
    //public GameObject scoreDisplay;  ALTERNATIVE

    public static int score = 0;

    // Start is called before the first frame update
    void Update()
    {
        scoreDisplay.text = "SCORE: " + score;

        //scoreDisplay.GetComponentInChildren<Text>().text = "SCORE: " + score;  ALTERNATIVE
    }
}
