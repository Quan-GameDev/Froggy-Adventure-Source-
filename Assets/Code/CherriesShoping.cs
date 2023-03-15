using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CherriesShoping : MonoBehaviour
{
    public TMPro.TextMeshProUGUI cherriesShoping;
    void Start()
    {
        cherriesShoping.text = ": " + ItemCollector.cherries.ToString();
    }

    public void GetScore()
    {
        int recievedScore = ItemCollector.cherries;
        cherriesShoping.text = ": " + recievedScore.ToString();
    }
}
