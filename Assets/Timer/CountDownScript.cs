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
            GetComponent<Text>().text = "Temps restant : 0:00";
            Debug.Log("Fini");
            StopCoroutine(timer());
            GetComponent<CountDownScript>().enabled = false;
        }

    }
}
