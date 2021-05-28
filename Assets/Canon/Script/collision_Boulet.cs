using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_Boulet : MonoBehaviour
{
    [SerializeField]
    private GameObject explosion;

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
        if (collision.collider.tag != "Canon")
        {
            if (collision.collider.name == "Plane")
            {
                Debug.Log("Plouf");
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Boum");
                GameObject e = Instantiate(explosion, transform.position, transform.rotation);
                Destroy(gameObject);
                if(collision.collider.name == "Bateau")
                {
                    GameObject.Find("Audio Source boulet-bateau").GetComponent<AudioSource>().Play();
                }
            }
        }
    }
}
