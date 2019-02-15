using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollisionScript : MonoBehaviour
{
    GameObject gameController;
    AudioSource audioSource;

    void Start()
    {
        gameController = GameObject.Find("FlightGameController");
        
        if (null == gameController)
        { // if AudioSource is missing
            Debug.LogWarning("GameController component missing from this gameobject.");
        }
        else if (gameController.GetComponent<AudioSource>() != null)
        {
            audioSource = gameController.GetComponent<AudioSource>();
        }
        else
        { // we should never enter this block
            Debug.Log(gameController);
            Debug.LogWarning("GameController does not have an AudioSource component.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");
        audioSource.Play();
        gameController.GetComponent<PointScript>().AddScore(1);
        Destroy(gameObject);
    }
}
