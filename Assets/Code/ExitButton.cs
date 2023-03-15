using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    [SerializeField] GameObject exitPanel;


    // Update is called once per frame
    public void ExitPanel()
    {
        SceneManager.LoadScene("Start Scene");
    }
}
