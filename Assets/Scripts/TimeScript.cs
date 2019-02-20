using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScript : MonoBehaviour {
    public float startTime;
    float timeLeft;
    public GameObject timeText;
    public GameObject car;
    public GameObject gameOverText;

    private void Start() {
        timeLeft = startTime;
    }

    void Update() {
        if (timeLeft > 0) {
            timeLeft -= Time.deltaTime;
            timeText.GetComponent<UnityEngine.UI.Text>().text = "Time: " + FormatTime(timeLeft);
        }
        if (timeLeft < 0) {
            StartCoroutine("GameOver");
        }
    }

    string FormatTime(float time) {
        int intTime = Mathf.RoundToInt(time * 100);
        int cs;
        int s;
        int m;
        int h;

        string res = "";
        cs = intTime % 100;
        intTime /= 100;
        s = intTime % 60;
        intTime /= 60;
        m = intTime % 60;
        h = intTime / 60;

        if (h > 0) {
            res += h + ":";
            if (m > 10) {
                res += m + ":";
            } else {
                res += "0" + m + ":";
            }
            if (s < 10) {
                res += "0" + s + "." + cs;
            } else {
                res += s + "." + cs;
            }
        } else {
            if (m > 0) {
                res += m + ":";
                if (s < 10) {
                    res += "0" + s + "." + cs;
                } else {
                    res += s + "." + cs;
                }
            } else {
                res += s + "." + cs;
            }
        }

        //res += h + ":" + m + ":" + s + "." + cs;
        return res;
    }

    public void AddTime(float time) {
        timeLeft += time;
    }

    IEnumerator GameOver() {
        timeLeft = 0;
        timeText.GetComponent<UnityEngine.UI.Text>().text = "Time: " + timeLeft;
        gameOverText.SetActive(true);
        yield return new WaitForSeconds(5f);
        gameOverText.SetActive(false);
        car.transform.position = new Vector3(0, 0, -500);
        car.transform.rotation = Quaternion.identity;
        car.transform.GetComponent<Rigidbody>().velocity = new Vector3() * 0;
        timeLeft = startTime;
        yield return null;
    }
}
