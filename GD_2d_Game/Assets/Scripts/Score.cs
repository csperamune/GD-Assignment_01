using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static bool oneScore;
    public Text scoreText;
    public Text highScoreText;
    private int pointVal = 0;

    public void AddScore(int toAdd)
    {
        pointVal = pointVal + toAdd;
        scoreText.text = pointVal.ToString();
        highScoreText.text = pointVal.ToString() + " points";
    }
}
