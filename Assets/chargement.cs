using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class chargement : MonoBehaviour
{
    private List<GameObject> listBonus;
    private List<int> xBonus;
    private List<int> zBonus;
    [SerializeField]
    private GameObject bonus1;
    //[SerializeField]
    //private GameObject bonus2;
    // Start is called before the first frame update
    void Start()
    {
        listBonus = new List<GameObject>();
        xBonus = new List<int> { -50, 50, -50,-110,  10, 70,-10};
        zBonus = new List<int> { -80, 30, 100,  30,-100,-50,  0};
        listBonus.Add(bonus1);
        //listBonus.Add(bonus2);
        for (int i = 0; i < xBonus.Count; i++)
        {
            GameObject g = Instantiate(listBonus[(int)Random.Range(0, listBonus.Count - 1)]);
            g.transform.position = new Vector3(xBonus[i], 3, zBonus[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
