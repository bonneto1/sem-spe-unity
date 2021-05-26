using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class affichage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameObject.Find("Bateau 1"))
        {
            
            Debug.Log(gameObject.activeInHierarchy);
            GameObject.Find("Main Camera").GetComponent<FollowCam>().target = gameObject.transform;
        }
    }
}
