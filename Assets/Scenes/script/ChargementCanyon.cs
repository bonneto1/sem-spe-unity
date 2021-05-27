using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargementCanyon : MonoBehaviour
{
    private List<GameObject> listBonus;
    private List<int> xBonus;
    private List<int> zBonus;
    [SerializeField]
    private GameObject bonus1;
    [SerializeField]
    private GameObject bonus2;
    [SerializeField]
    private GameObject bonus3;
    // Start is called before the first frame update
    void Start()
    {
        listBonus = new List<GameObject>();
        xBonus = new List<int> { -135, -24, -104, -24, 26, 142, 71 };
        zBonus = new List<int> { 13, 51, -84, -22, -41, 7, 58 };
        listBonus.Add(bonus1);
        listBonus.Add(bonus2);
        listBonus.Add(bonus3);
        for (int i = 0; i < xBonus.Count; i++)
        {
            int rand = Random.Range(0, listBonus.Count);
            GameObject g = Instantiate(listBonus[rand]);
            g.transform.position = new Vector3(xBonus[i], 3, zBonus[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
