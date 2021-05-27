using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangementMenu : MonoBehaviour
{
    private bool m_lance;
    // Start is called before the first frame update
    void Start()
    {
        m_lance = false;
        gameObject.GetComponent<AudioSource>().playOnAwake = true;
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
            
        }
    }
}
