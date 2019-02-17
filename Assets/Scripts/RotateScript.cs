using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotateScript : MonoBehaviour
{
    void Update()
    {
        transform.DORotate(transform.rotation, 1, RotateMode.FastBeyond360);
    }
}
