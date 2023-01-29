using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    void Start()
    {
        //Buscamos los clips de audio y se lo asignamos a las variables
        GameManager.singleton.Boton = Resources.Load<AudioClip>("boton");
        GameManager.singleton.Cesta = Resources.Load<AudioClip>("cesta");
        GameManager.singleton.Disparo = Resources.Load<AudioClip>("disparo");
        GameManager.singleton.Pintura = Resources.Load<AudioClip>("pintura");
        GameManager.singleton.Win = Resources.Load<AudioClip>("win");


        GameManager.singleton.AudioSCR = GetComponent<AudioSource>();
    }

    
    
}
