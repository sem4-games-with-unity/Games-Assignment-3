using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScript : MonoBehaviour
{
    public float startTime;
    float timeLeft;
    public GameObject timeText;

    private void Start()
    {
        timeLeft = startTime;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeText.GetComponent<UnityEngine.UI.Text>().text = "Time: " + timeLeft;
        if(timeLeft <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {

    }
}
