using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bateau_collision : MonoBehaviour
{
    private int NbCollisions;
    [SerializeField]
    private int NbVies;

    // Start is called before the first frame update
    void Start()
    {
        NbCollisions = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        NbCollisions += 1;
        if (NbCollisions >= 5)
        {
            Destroy(this.gameObject);  
        }
    }
}
