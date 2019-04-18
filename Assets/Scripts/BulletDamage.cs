using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Eksplosion;

    void Start()
    {
        Destroy(transform.gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.transform.tag);
        if (collision.transform.tag == "box")
        {
            GetComponent<AudioSource>().Play();
            Instantiate(Eksplosion, new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z), Quaternion.identity);
            Destroy(collision.transform.gameObject, 0);
            
        }
    }

}
