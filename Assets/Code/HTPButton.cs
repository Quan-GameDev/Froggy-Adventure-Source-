using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HTPButton : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        if(Panel != null)
        {
            Panel.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Panel == false)
        {
            Panel.SetActive(true);
            
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && Panel == true)
        {
            Panel.SetActive(false);
           
        }
    }
}
