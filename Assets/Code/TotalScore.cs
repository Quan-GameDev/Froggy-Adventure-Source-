using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TotalScore : MonoBehaviour
{
    public TMPro.TextMeshProUGUI totalscoreText;
    void Start()
    {
        ItemCollector.highscore = PlayerPrefs.GetInt("highscore");
        totalscoreText.text = ": " + ItemCollector.highscore.ToString();
    }
    public void GetScore()
    {
        int recievedScore = ItemCollector.highscore;
        totalscoreText.text = ": " + recievedScore.ToString();
    }
}
