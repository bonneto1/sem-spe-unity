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
    private GameObject menuDefaite;
    [SerializeField]
    private GameObject menuVictoire;

    public float time = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
        nbCollisions = 0;
        intervalTire = 3;
        derniereTouche = 0;

        StartCoroutine(timer());
        time += 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator timer()
    {
        while (time > 0)
        {
            time--;
            yield return new WaitForSeconds(1f);
            GetComponent<Text>().text = "Temps restant : " + string.Format("{0:0}:{1:00}", Mathf.Floor(time / 60), time % 60);


        }
        if (time == 0)
        {
            Debug.Log("Fini");
        }

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
            if (nbCollisions >= nbVies || time == 0)
            {
                GameObject m = Instantiate(menuDefaite, transform.position, transform.rotation);
                Destroy(gameObject);
                GameObject.Find("Main Camera").GetComponent<FollowCam>().enabled = false;
            }

            derniereTouche = Time.realtimeSinceStartup; 

        }

        else if(collision.gameObject.name == "ligne d'arrivee" && time > 0)// et le timer pas fini 
        {
            Debug.Log("bou");
            GameObject m = Instantiate(menuVictoire, transform.position, transform.rotation);
            Destroy(gameObject);
            GameObject.Find("Main Camera").GetComponent<FollowCam>().enabled = false;
        }


    }
}
