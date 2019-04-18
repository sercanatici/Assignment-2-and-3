using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Plane : MonoBehaviour
{
    public int points;
    public Text text;
    Tween tween;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        text.transform.DOScale(1, .5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.tag == "coin")
        {
            points++;
            text.text = "Point: " + points;
            GetComponent<AudioSource>().Play();

            StartCoroutine("textAnimation");
            print(points);
            Destroy(collision.transform.gameObject, 0);
        }
    }


    IEnumerator textAnimation()
    {
        tween = text.transform.DOScale(2,.5f);
        yield return tween.WaitForCompletion();
        tween = text.transform.DOScale(1, .5f);
        
    }
}
