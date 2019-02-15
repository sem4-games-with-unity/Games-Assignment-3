using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public GameObject explosion;

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        GameObject target = collision.collider.gameObject;
        Instantiate(explosion, target.transform.position, target.transform.rotation);
        Destroy(target);
    }
}
