using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{

    public GameObject pauseMenu, areYouSureMenuHome, areYouSureMenuBack;

    private void Start()
    {
        Time.timeScale = 1;
    }


    //Funcion para cargar la escena colorear
    public void NivelColor()
    {
        GameManager.singleton.PlaySound("boton");
        SceneManager.LoadScene("Colorear");
    }

    //Funcion para cargar la escena cesta
    public void NivelCesta()
    {
        GameManager.singleton.PlaySound("boton");

        if (PlayerPrefs.GetInt("NumberStars") >= 1)
        {
            SceneManager.LoadScene("Cesta");
        }
        
    }
    //Funcion para cargar la escena tocar
    public void NivelDisparo()
    {
        GameManager.singleton.PlaySound("boton");

        if (PlayerPrefs.GetInt("NumberStars") >= 2)
        {
            SceneManager.LoadScene("Tocar");
        }
        
    }
    //Funcion para cargar la escena inicio
    public void GoMenu()
    {
        GameManager.singleton.PlaySound("boton");

        SceneManager.LoadScene("Inicio");
    }
    //Funcion para cargar la escena fruta
    public void GoFruta()
    {
        GameManager.singleton.PlaySound("boton");

        SceneManager.LoadScene("Fruta");
    }
    //Funcion para pausar el juego
    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
    //Funcion para despausar el juego
    public void RestartGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
    //Funcion para activar el cartel de estar seguro de regresar al menu principal
    public void ActiveAreYouSureHome()
    {
        areYouSureMenuHome.SetActive(true);
    }

    //Funcion para activar el cartel de estar seguro de regresar al selector de niveles
    public void ActiveAreYouSureBack()
    {
        areYouSureMenuBack.SetActive(true);
    }
    //Funcion para desactivar el cartel de estar seguro de regresar al menu principal

    public void DisactiveAreYouSureHome()
    {
        areYouSureMenuHome.SetActive(false);
    }

    //Funcion para desactivar el cartel de estar seguro de regresar al selector de niveles

    public void DisactiveAreYouSureBack()
    {
        areYouSureMenuBack.SetActive(false);
    }


    //Funcion para activar y desactivar el audio

    public void MuteSound()
    {
        if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
        } else if (AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
        }
    }
}
