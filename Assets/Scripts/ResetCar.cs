using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCar : MonoBehaviour
{
    public GameObject Car;
    public GameObject Reset;
    public void Respawn()
    {
        
        Car.transform.eulerAngles = new Vector3(0, 0, 0);
        Car.transform.position = new Vector3(0, 5, 0);

    }
}
