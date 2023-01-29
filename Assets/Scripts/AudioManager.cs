using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GameManager.singleton.Boton = Resources.Load<AudioClip>("boton");
        GameManager.singleton.Cesta = Resources.Load<AudioClip>("cesta");
        GameManager.singleton.Disparo = Resources.Load<AudioClip>("disparo");
        GameManager.singleton.Pintura = Resources.Load<AudioClip>("pintura");
        GameManager.singleton.Win = Resources.Load<AudioClip>("win");


        GameManager.singleton.AudioSCR = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
