using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour
{
    public float time = 10f;


    void Start()
    {
        StartCoroutine(timer());
        
    }


    public IEnumerator timer()
    {
        while (time > 0)
        {
            
            time--;
            yield return new WaitForSeconds(1f);
            if (!GameObject.Find("Main Camera").GetComponent<FollowCam>().enabled)
                break;
            GetComponent<Text>().text = "Temps restant : " + string.Format("{0:0}:{1:00}", Mathf.Floor(time / 60), time % 60);

        }
        //GetComponent<Text>().text = "Temps restant : 0:00";
        GetComponent<CountDownScript>().enabled = false;
    }
}
