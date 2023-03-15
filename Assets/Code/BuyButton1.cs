using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BuyButton1 : MonoBehaviour
{
    public TMPro.TextMeshProUGUI buyText;
    public TMPro.TextMeshProUGUI cherriesShoping;
    [SerializeField] public AudioSource buySoundEffect;
    public bool chekedbuy = false;

    
    public void Buy1()
    {
        buySoundEffect.Play();
        if (ItemCollector.cherries >= 10 && !chekedbuy)
        {
            ItemCollector.cherries -= 10;
            PlayerMovement.moveSpeed = 10f;
            int recievedScore = ItemCollector.cherries;
            cherriesShoping.text = ": " + recievedScore.ToString();
            chekedbuy = true;
        }
    }
}
