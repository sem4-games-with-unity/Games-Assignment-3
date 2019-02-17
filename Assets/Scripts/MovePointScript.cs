using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovePointScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("PointMover");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PointMover()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);
            if (Random.value < 0.25f)
            {
                transform.DOMove(new Vector3(Random.Range(-1000f, 1000f), Random.Range(50f, 150f), Random.Range(-1000f, 1000f)), Random.value).SetEase(Ease.OutBounce);
            }
            yield return new WaitForEndOfFrame();
        }
    }
}
