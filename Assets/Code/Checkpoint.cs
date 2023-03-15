using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    public AudioSource checkpointSound;
    public bool levelcheckpoint = false;
    public Vector3 spawnPoint;
    public GameObject checkpoint;
    public void Start()
    {
        checkpointSound = GetComponent<AudioSource>();
        spawnPoint = gameObject.transform.position;
    }
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelcheckpoint)
        {
            checkpointSound.Play();
            levelcheckpoint = true;
            spawnPoint = gameObject.transform.position; 
            Invoke("CheckpointLevel", 2f);
        }
    }

    
}
