using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    private float time;
    public float TimerIntervalle = -5f;
    private float tick;


    void Awake()
    {
        time = 60;
        tick = TimerIntervalle;
    }


    void Update()
    {
        GetComponent<Text>().text = string.Format("{0:0}:{1:00}",Mathf.Floor(time/60),time%60);
        time = (int)Time.time;


        if (time == tick)
        {
            tick = time - TimerIntervalle;
            //Executer code timer




        }

    }

    void TimerExecute()
    {

    }
}
