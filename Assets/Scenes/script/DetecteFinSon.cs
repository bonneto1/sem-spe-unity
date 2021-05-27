using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetecteFinSon : MonoBehaviour
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
        if(GetComponent<AudioSource>().isPlaying)
        {
            m_lance = true;
        }
        if(m_lance && !GetComponent<AudioSource>().isPlaying)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
