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

    public void NivelColor()
    {
        GameManager.singleton.PlaySound("boton");
        SceneManager.LoadScene("Colorear");
    }

    public void NivelCesta()
    {
        GameManager.singleton.PlaySound("boton");

        if (PlayerPrefs.GetInt("NumberStars") >= 1)
        {
            SceneManager.LoadScene("Cesta");
        }
        
    }

    public void NivelDisparo()
    {
        GameManager.singleton.PlaySound("boton");

        if (PlayerPrefs.GetInt("NumberStars") >= 2)
        {
            SceneManager.LoadScene("Tocar");
        }
        
    }

    public void GoMenu()
    {
        GameManager.singleton.PlaySound("boton");

        SceneManager.LoadScene("Inicio");
    }

    public void GoFruta()
    {
        GameManager.singleton.PlaySound("boton");

        SceneManager.LoadScene("Fruta");
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void ActiveAreYouSureHome()
    {
        areYouSureMenuHome.SetActive(true);
    }

    public void ActiveAreYouSureBack()
    {
        areYouSureMenuBack.SetActive(true);
    }

    public void DisactiveAreYouSureHome()
    {
        areYouSureMenuHome.SetActive(false);
    }

    public void DisactiveAreYouSureBack()
    {
        areYouSureMenuBack.SetActive(false);
    }

    

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
