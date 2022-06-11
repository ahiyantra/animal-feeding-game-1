using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject sensor;
    // Start is called before the first frame update
    private void Start()
    {
        sensor = GameObject.Find("Sensor");
    }

    void OnTriggerEnter(Collider other)
    {
        // Instead of destroying the projectile when it collides with an animal
        //Destroy(other.gameObject); 

        // Just deactivate the food and destroy the animal
        if (other.gameObject.CompareTag("food"))
        {
            other.gameObject.SetActive(false);
            Destroy(gameObject);
            sensor.GetComponent<FedCounter>().animalsHit++;
        }
    }

}
