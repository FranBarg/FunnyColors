using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public sealed class GameManager
{
    private float _points;
    public float Points
    {
        get { return _points; }
        set { _points = value; }
    }

    private AudioClip _boton, _cesta, _disparo, _win, _pintura;
    public AudioClip Boton
    {
        get { return _boton; }
        set { _boton = value; }
    }

    public AudioClip Cesta
    {
        get { return _cesta; }
        set { _cesta = value; }
    }

    public AudioClip Disparo
    {
        get { return _disparo; }
        set { _disparo = value; }
    }

    public AudioClip Win
    {
        get { return _win; }
        set { _win = value; }
    }

    public AudioClip Pintura
    {
        get { return _pintura; }
        set { _pintura = value; }
    }

    private AudioSource _audioSCR;
    public AudioSource AudioSCR
    {
        get { return _audioSCR; }
        set { _audioSCR = value; }
    }


    //Creamos una referencia estática que apunta al Singleton
    private static GameManager instance;

    public static GameManager singleton
    {
        //El get nos sirve para obtener la información del Singleton
        get
        {
            //Comprobamos primero que la instancia esté vacía
            if (instance == null)
            {
                //Rellenamos la referencia del Singleton
                instance = new GameManager();

            }
            //Nos devuelve la información de la instancia
            return instance;
        }
    }

    public void PlaySound(string clip)
    {
        switch (clip)
        {
            case "boton":
                _audioSCR.PlayOneShot(_boton);
                break;
            case "cesta":
                _audioSCR.PlayOneShot(_cesta);
                break;
            case "disparo":
                _audioSCR.PlayOneShot(_disparo);
                break;
            case "pintura":
                _audioSCR.PlayOneShot(_pintura);
                break;
            case "win":
                _audioSCR.PlayOneShot(_win);
                break;
        }
    }

}
