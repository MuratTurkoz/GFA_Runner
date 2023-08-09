using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOScale(2, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.DOScale(2, 2);
    }
}
