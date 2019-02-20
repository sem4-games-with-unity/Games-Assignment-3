using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTriggerScript : MonoBehaviour
{
    public float time;
    GameObject gameController;
    GameObject car;

    void Start()
    {
        gameController = GameObject.Find("CarGameController");
        car = GameObject.Find("Car");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.Equals(car)){
            gameController.GetComponent<TimeScript>().AddTime(time);
        }    
    }
}
