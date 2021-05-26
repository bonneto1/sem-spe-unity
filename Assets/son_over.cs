using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class son_over : MonoBehaviour
{
    [SerializeField]
    private AudioSource m_source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseOver()
    {
        AudioSource m = Instantiate(m_source);
    }
}
