using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LancementMap : MonoBehaviour
{
    public void BoutonZoneHerbe()
    {
        SceneManager.LoadScene(1);
    }

    public void BoutonZoneNeige()
    {
        SceneManager.LoadScene(2);
    }

    public void BoutonZoneCanyon()
    {
        SceneManager.LoadScene(3);
    }

}
