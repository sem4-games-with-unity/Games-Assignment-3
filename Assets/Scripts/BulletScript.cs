using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gunpoint;
    public int speed;
    public int bulletPool = 20;
    List<GameObject> bullets;

    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();
        for(int i = 0; i < bulletPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(bullet);
            obj.SetActive(false);
            bullets.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootBullet();
        }
    }

    private void FixedUpdate()
    {
        
    }

    void ShootBullet()
    {
        //GameObject obj = Instantiate(bullet, gunpoint.transform.position, gunpoint.transform.rotation);
        //obj.GetComponent<Rigidbody>().velocity = speed * gunpoint.transform.forward;
        for (int i = 0; i < bullets.Count; i++)
        {
            if (!bullets[i].activeInHierarchy)
            {
                bullets[i].transform.position = gunpoint.transform.position;
                bullets[i].transform.rotation = gunpoint.transform.rotation;
                bullets[i].SetActive(true);
                bullets[i].GetComponent<Rigidbody>().velocity = speed * gunpoint.transform.forward;
                break;
            }
        }
    }
}
