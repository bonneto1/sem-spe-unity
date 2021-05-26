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
        //AudioSource m_source = GetComponent<AudioSource>();
        //m_source.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void OnMouseOver()
    {
        Debug.Log("dessus");
        if (!m_source.isPlaying)
            m_source.Play();
    }
}
