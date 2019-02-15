using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject enemy;
    public GameObject car;
    public int count;
    public void SpawnEnemies()
    {
        for (int i = 0; i < count; i++)
        {
            Instantiate(enemy, new Vector3(i* Random.Range(-10, 10), 0, i* Random.Range(-10, 10)), Quaternion.identity);
        }
    }

    public void RespawnCar()
    {
        car.transform.position = new Vector3(0, 0, 0);
        car.transform.rotation = Quaternion.identity;
        car.transform.GetComponent<Rigidbody>().velocity = new Vector3() * 0;
    }
}
