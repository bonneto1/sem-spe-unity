using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPrincipal : MonoBehaviour
{
    [SerializeField]
    AudioSource m_source;

    public void Start()
    {
        
    }
    public void BoutonJouer()
    {

        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BoutonQuitter()
    {
        
        
        Application.Quit();
    }
    
}
