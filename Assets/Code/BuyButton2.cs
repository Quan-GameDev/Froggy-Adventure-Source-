using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BuyButton2 : MonoBehaviour
{
    public TMPro.TextMeshProUGUI buyText;
    public TMPro.TextMeshProUGUI cherriesShoping;
    [SerializeField] public AudioSource buySoundEffect;
    public bool chekedbuy = false;

    
    public void Buy2()
    {
        buySoundEffect.Play();
        if (ItemCollector.cherries >= 10 && !chekedbuy)
        {
            ItemCollector.cherries -= 10;
            PlayerMovement.jumpForce = 18f;
            int recievedScore = ItemCollector.cherries;
            cherriesShoping.text = ": " + recievedScore.ToString();
            chekedbuy = true;
        }
    }
}
