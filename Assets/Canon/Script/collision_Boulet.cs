using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_Boulet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "WaterProDaytime" || collision.collider.name == "Plane")
        {
            Debug.Log("Plouf");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Boum");
            Destroy(gameObject);
        }
    }
}
