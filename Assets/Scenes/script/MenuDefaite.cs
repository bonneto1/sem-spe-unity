using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDefaite : MonoBehaviour
{
    public void BoutonMenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    public void BoutonRejouer()
    {
        SceneManager.LoadScene(1);
    }

    public void BoutonQuitterJeu()
    {
        Application.Quit();
    }
}
