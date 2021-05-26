using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipale : MonoBehaviour
{
    
    public void BoutonJouer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BoutonQuitter()
    {
        Debug.Log("Pouf");
        Application.Quit();
    }
}
