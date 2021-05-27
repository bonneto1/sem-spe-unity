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
    private int yVie;
    private int xVie;

    private List<int> xPoussin;
    private List<int> zPoussin;
    private List<GameObject> ptnVie;

    [SerializeField]
    private int nbVies;
    [SerializeField]
    private GameObject menuDefaite;
    [SerializeField]
    private GameObject menuVictoire;
    [SerializeField]
    private int poussinARamasser;
    [SerializeField]
    private GameObject poussin;
    [SerializeField]
    private GameObject vie;

    // Start is called before the first frame update
    void Start()
    {
        nbCollisions = 0;
        intervalTire = 3;
        derniereTouche = 0;
        nbPoussins = 0;
        GameObject.Find("CompteurPoussin").GetComponent<Text>().text = nbPoussins+"/"+poussinARamasser;
        GameObject.Find("ligne d'arrivee").GetComponent<BoxCollider>().enabled = false;
        ptnVie = new List<GameObject>();

        if (gameObject.scene.name == "ZoneHerbe")
        {
            xPoussin = new List<int> {  1, 49,  89, -10, -95, -45, 118, -57,  -26, 40};
            zPoussin = new List<int> { 45, 87, -28, -60,  35, 119, -32,  88, -134, 62};
        }
        else if (gameObject.scene.name == "ZoneNeige")
        {
            xPoussin = new List<int> { -102,  -7,  -59,  97,  -8,-115, -36, 99,   66,  47 };
            zPoussin = new List<int> {  -32, -73, -118, -32, 119,  15,  91, 52, -136, 127 };
        }
        else if (gameObject.scene.name == "ZoneCanyon")
        {
            xPoussin = new List<int> { 0, 0, 0, 0, 0 };
            zPoussin = new List<int> { 0, 0, 0, 0, 0 };
        }
        for (int i = 0; i < poussinARamasser; i++)
        {
            GameObject g = Instantiate(poussin);
            int pos = (int)Random.Range(0, xPoussin.Count - 1);
            g.transform.position = new Vector3(xPoussin[pos], 3, zPoussin[pos]);
            Debug.Log("Poussin" + i+" pos x : "+xPoussin[pos]+" pos z : "+zPoussin[pos]);
            xPoussin.RemoveAt(pos);
            zPoussin.RemoveAt(pos);
        }
        yVie = 20;
        xVie = 20;
        for (int i = 0; i < nbVies; i++)
        {
            GameObject v = Instantiate(vie);
            v.transform.position.Set(i*40+xVie, -(i*40+yVie), 0);
            if(i == 5)
            {
                yVie = 60;
                xVie -= 180;
            }
            ptnVie.Add(v);
        }
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
            if (collision.gameObject.name == "Heart(Clone)")//hp up
            {
                nbVies += 1;
                Destroy(collision.gameObject);
                int nbPtnVie = ptnVie.Count;
                if(nbPtnVie >= 5)
                {
                    yVie = 60;
                    xVie -= 180;
                }
                GameObject v = Instantiate(vie);
                v.transform.position.Set(nbPtnVie * 40 + 20, -(nbPtnVie * 40 + yVie), 0);
                
            }
            else if (collision.gameObject.name == "chrono(Clone)") //bonus temps
            {
                GameObject.Find("Text").GetComponent<CountDownScript>().time += 10;
                Destroy(collision.gameObject);
            }
            else if (collision.gameObject.name == "poussin(Clone)") // compteur de poussins
            {
                nbPoussins += 1;
                GameObject.Find("CompteurPoussin").GetComponent<Text>().text = nbPoussins + "/" + poussinARamasser;
                if(nbPoussins == poussinARamasser)
                    GameObject.Find("ligne d'arrivee").GetComponent<BoxCollider>().enabled = true;
                Destroy(collision.gameObject);
            }
            
        }
        else if (intervalTire <= Time.realtimeSinceStartup - derniereTouche && collision.gameObject.tag == "Obstacle")
        {
            ////////////////////////////////////
            nbVies--;
            if (nbVies <= 0)
            {
                GameObject m = Instantiate(menuDefaite, transform.position, transform.rotation);
                Destroy(gameObject);
                GameObject.Find("Main Camera").GetComponent<FollowCam>().enabled = false;
            }

            derniereTouche = Time.realtimeSinceStartup; 

        }

        else if(collision.gameObject.name == "ligne d'arrivee" && nbPoussins == poussinARamasser)
        {
            
            GameObject m = Instantiate(menuVictoire, transform.position, transform.rotation);
            Destroy(gameObject);
            GameObject.Find("Main Camera").GetComponent<FollowCam>().enabled = false;
        }
        


    }
}
