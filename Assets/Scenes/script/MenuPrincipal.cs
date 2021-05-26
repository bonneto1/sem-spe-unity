using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPrincipal : MonoBehaviour
{
    [SerializeField]
    AudioSource m_source;

    private float time;

    public void Start()
    {
        
    }
    public void BoutonJouer()
    {
        if(!m_source.isPlaying)
            m_source.PlayDelayed(2);
        //while(m_source.isPlaying){ Debug.Log("est joué");}
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BoutonQuitter()
    {

        AudioSource m = Instantiate(m_source);
        
        Application.Quit();
    }
}
