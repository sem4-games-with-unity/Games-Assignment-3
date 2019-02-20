using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PointScript : MonoBehaviour
{
    public GameObject point;
    public int count;
    int score = 0;
    public GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("ScoreText");
        SpawnPoints();
        score = 0;
        UpdateScore();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPoints()
    {
        for (int i = 0; i < count; i++)
        {
            Vector3 position = new Vector3(i * Random.Range(-100f, 100f), Random.Range(50f, 150f), i * Random.Range(-100f, 100f));
            Instantiate(point, position, Quaternion.identity);
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.GetComponent<UnityEngine.UI.Text>().text = "Score: " + score;
        StartCoroutine("FlashText");
    }

    IEnumerator FlashText()
    {
        scoreText.GetComponent<UnityEngine.UI.Text>().fontSize = 25;
        yield return new WaitForSeconds(.5f);
        scoreText.GetComponent<UnityEngine.UI.Text>().fontSize = 20;
        yield return null;
    }
}
