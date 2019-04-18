using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CoinMove : MonoBehaviour
{
    // Start is called before the first frame update
    Tween tween;
    void Start()
    {
        StartCoroutine("coinmove");
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    IEnumerator coinmove()
    {
        while (true)
        {
            tween = transform.DOMoveX(transform.position.x + 10, 1f);
            yield return tween.WaitForCompletion();
            tween = transform.DOMoveX(transform.position.x - 10, 1f);
            yield return tween.WaitForCompletion();
            tween = transform.DOMoveX(transform.position.x - 10, 1f);
            yield return tween.WaitForCompletion();
            tween = transform.DOMoveX(transform.position.x + 10, 1f);
            yield return tween.WaitForCompletion();
        }
    }
}
