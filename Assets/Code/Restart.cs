using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    public TMPro.TextMeshProUGUI restartscoreText;
    public void RestartButton()
    {
        SceneManager.LoadScene("Level 1");
        Time.timeScale = 1f;
        ItemCollector.cherries = 0;
    }
}
