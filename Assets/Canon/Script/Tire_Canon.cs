using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class Tire_Canon : MonoBehaviour
{
    [SerializeField]
    private int vitesse;
    [SerializeField]
    private float intervalTire;
    [SerializeField]
    private Rigidbody Boulet;

    private float dernierTire;
    private int vitesseMax;
    private bool monte;
    private int delay;


    // Start is called before the first frame update
    void Start()
    {
        vitesseMax = vitesse;
        monte = false;
        delay = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(intervalTire <= Time.realtimeSinceStartup - dernierTire)
        {
            Rigidbody b = Instantiate(Boulet, transform.position, transform.rotation);
            b.velocity = -transform.forward * this.vitesse;
            
            dernierTire = Time.realtimeSinceStartup;
        }
        if (delay == 23)
        {
            if (monte)
            {
                vitesse++;
                if (vitesseMax == vitesse)
                {
                    monte = false;
                }
            }
            else
            {
                vitesse--;
                if (vitesseMax - vitesse == 5)
                {
                    monte = true;
                }
            }
            delay = 0;
        }
        else
        {
            delay++;
        }
    }
}
