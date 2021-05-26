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

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Panel").GetComponent<Image>().color = new Color(0, 0, 0, 0);
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
        if (intervalTire <= Time.realtimeSinceStartup - derniereTouche && collision.gameObject.name != "Plane")
        {
        nbCollisions += 1;
        Debug.Log("toucher");
        if (nbCollisions >= nbVies)
            {

                Destroy(gameObject);
                GameObject.Find("Panel").GetComponent<Image>().color = new Color(255, 0, 0, 1);
                GameObject.Find("Main Camera").GetComponent<FollowCam>().enabled = false;
            }
        derniereTouche = Time.realtimeSinceStartup; 
        }
    }
}
