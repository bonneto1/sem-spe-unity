using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Quitter : MonoBehaviour
{
    private bool m_lance;
    // Start is called before the first frame update
    void Start()
    {
        m_lance = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<AudioSource>().isPlaying)
        {
            m_lance = true;
        }
        if (m_lance && !GetComponent<AudioSource>().isPlaying)
        {
            Application.Quit();
        }
    }
}
