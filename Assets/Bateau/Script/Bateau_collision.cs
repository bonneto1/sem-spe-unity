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
    private int nbPoussins;
    
    [SerializeField]
    private int nbVies;
    [SerializeField]
    private GameObject menuDefaite;
    [SerializeField]
    private GameObject menuVictoire;
    [SerializeField]
    private int poussinARamasser;

    // Start is called before the first frame update
    void Start()
    {
        nbCollisions = 0;
        intervalTire = 3;
        derniereTouche = 0;
        nbPoussins = 0;
        GameObject.Find("CompteurPoussin").GetComponent<Text>().text = "Nombre de poussins ramassés :"+nbPoussins+"/"+poussinARamasser;


    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("Text").GetComponent<CountDownScript>().isActiveAndEnabled)
        {
           
            GameObject m = Instantiate(menuDefaite, transform.position, transform.rotation);
            Destroy(gameObject);
            GameObject.Find("Main Camera").GetComponent<FollowCam>().enabled = false;
        }

    }

    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bonus")
        {
            Debug.Log("BAM");
            Destroy(collision.gameObject);
            if (collision.gameObject.name == "coeur(Clone)")//hp up
            {
                nbVies += 1;
            }
            else if (collision.gameObject.name == "chrono(Clone)") //bonus temps
            {
                GameObject.Find("Text").GetComponent<CountDownScript>().time += 10;
                Destroy(collision.gameObject);
            }
            else if (collision.gameObject.name == "poussin(Clone)") // compteur de poussins
            {
                nbPoussins += 1;
                Destroy(collision.gameObject);
                GameObject.Find("CompteurPoussin").GetComponent<Text>().text = "Nombre de poussins ramassés :" + nbPoussins + "/" + poussinARamasser;
            }
        }
        else if (intervalTire <= Time.realtimeSinceStartup - derniereTouche && collision.gameObject.tag == "Obstacle")
        {
            nbCollisions += 1;
            if (nbCollisions >= nbVies)
            {
                GameObject m = Instantiate(menuDefaite, transform.position, transform.rotation);
                Destroy(gameObject);
                GameObject.Find("Main Camera").GetComponent<FollowCam>().enabled = false;
            }

            derniereTouche = Time.realtimeSinceStartup; 

        }

        else if(collision.gameObject.name == "ligne d'arrivee")
        {
            
            GameObject m = Instantiate(menuVictoire, transform.position, transform.rotation);
            Destroy(gameObject);
            GameObject.Find("Main Camera").GetComponent<FollowCam>().enabled = false;
        }
        


    }
}
