﻿using System.Collections;
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
        WaitForSeconds wait = new WaitForSeconds(10f);
        while (true)
        {
            yield return wait;
            if (Random.value < 0.25f)
            {
                transform.DOMove(new Vector3(Random.Range(-1000f, 1000f), Random.Range(50f, 150f), Random.Range(-1000f, 1000f)),
                                 Random.value * 60).SetEase(Ease.OutBounce);
            }
//            yield return new WaitForEndOfFrame();
        }
    }
}
