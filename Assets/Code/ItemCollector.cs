using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public static int cherries = 0;
    public static int highscore = 0;

    [SerializeField] public TMPro.TextMeshProUGUI cherriesText;
    [SerializeField] public TMPro.TextMeshProUGUI highscoreText;
    [SerializeField] private AudioSource collectionSoundEffect;

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        highscoreText.text = "Highest Score: " + highscore.ToString();
        int recievedPoints = ItemCollector.cherries;
        cherriesText.text = "Cherries: " + recievedPoints.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Cherries: " + cherries;
            
            if (highscore < cherries)
            {              
                PlayerPrefs.SetInt("highscore", cherries);               
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            cherries = 0;
        }
    }
}
