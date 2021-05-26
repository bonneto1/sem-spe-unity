using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bateau_collision : MonoBehaviour
{
    private int nbCollisions;
    private float intervalTire;
    private float derniereTouche;
    
    
    [SerializeField]
    private int nbVies;
    [SerializeField]
    private GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        
        nbCollisions = 0;
        intervalTire = 3;
        derniereTouche = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bonus")
        {
            if(gameObject.name == "Vie(Clone)")//hp up
            {
                nbVies += 1;
            }
           /* else if () //bonus temps
            {

            }*/
        }
        else if (intervalTire <= Time.realtimeSinceStartup - derniereTouche && collision.gameObject.tag == "Obstacle")
        {
            nbCollisions += 1;
            if (nbCollisions >= nbVies)
            {
                GameObject m = Instantiate(menu, transform.position, transform.rotation);
                Destroy(gameObject);
                GameObject.Find("Main Camera").GetComponent<FollowCam>().enabled = false;
            }

            derniereTouche = Time.realtimeSinceStartup; 

        }
    }
}
