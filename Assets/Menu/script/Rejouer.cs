using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rejouer : MonoBehaviour
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
            if (gameObject.scene.name == "ZoneHerbe")
            SceneManager.LoadScene(1);
            else if (gameObject.scene.name == "ZoneNeige")
                SceneManager.LoadScene(2);
            else if (gameObject.scene.name == "ZoneCanyon")
                SceneManager.LoadScene(3);
        }
    }
}
