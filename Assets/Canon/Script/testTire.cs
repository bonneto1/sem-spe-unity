using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testTire : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private int vitesse;
    [SerializeField]
    private float intervalTire;
    [SerializeField]
    private Rigidbody Boulet;

    private float dernierTire;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(intervalTire <= Time.realtimeSinceStartup - dernierTire)
        {
            Rigidbody b = Instantiate(Boulet, transform.position, transform.rotation);
            b.velocity = transform.forward * vitesse;
            //Boulet.SetActive(true);


            dernierTire = Time.realtimeSinceStartup;
        }
    }
}
