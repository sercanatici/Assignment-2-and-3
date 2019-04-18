using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarScript : MonoBehaviour
{
    float countdown;
    public GameObject Reset;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        countdown = 10;
        Reset.SetActive(false);
        StartCoroutine("Timer");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (Vector3.Dot(transform.up, Vector3.down) > 0)
        {

            Reset.SetActive(true);
            print("RAMT");
        }
        else
        {
            Reset.SetActive(false);
        }

    }

    IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            float counter = countdown - 1;
            countdown = counter;
            text.text = "Timer: " + countdown;
            if (countdown <= 0)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                transform.position = new Vector3(0, 5, 0);
                countdown = 10;
            }
        }

    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.tag == "coin")
        {
            print("point");
            countdown += 10;
            Destroy(collision.transform.gameObject,0);
        }
    }
}
