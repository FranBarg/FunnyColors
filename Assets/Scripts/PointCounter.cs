using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointCounter : MonoBehaviour
{
    public Event youWin;
    public Text pointsText;
    Scene currentScene;
    string sceneName;
    public float time, timeMax;
    public bool end;
    

    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos los puntos a 0
        GameManager.singleton.Points = 0;
        //Obtenemos el nombre de la escena actual
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        //Actualizamos continuamente los puntos que tenemos en pantalla
        pointsText.text = "Puntos: " + GameManager.singleton.Points.ToString() + "/30";

        if (sceneName == "Tocar")
        {
            //Detectamos cuando llega el objetivo de puntos final y cargamos la siguiente escena
            if (GameManager.singleton.Points >= 30)
            {
                if (!end)
                {
                    GameManager.singleton.PlaySound("win");
                    //Detectamos que se activa el observer y realizamos su funcion
                    youWin.Ocurred(this.gameObject);
                    end = true;
                }
                time = time + Time.deltaTime;
                if (time >= timeMax)
                {
                    if (PlayerPrefs.GetInt("NumberStars") < 3)
                    {
                        PlayerPrefs.SetInt("NumberStars", 3);
                    }

                    SceneManager.LoadScene("Fruta");

                }
            }
        }
        else if (sceneName == "Cesta")
        {
            //Detectamos cuando llega el objetivo de puntos final y cargamos la siguiente escena
            if (GameManager.singleton.Points >= 30)
            {
                if (!end)
                {
                    GameManager.singleton.PlaySound("win");

                    //Detectamos que se activa el observer y realizamos su funcion
                    youWin.Ocurred(this.gameObject);
                    end = true;
                }
                time = time + Time.deltaTime;
                if (time >= timeMax)
                {
                    if (PlayerPrefs.GetInt("NumberStars") < 2)
                    {
                        PlayerPrefs.SetInt("NumberStars", 2);
                    }
                    if (PlayerPrefs.GetInt("NumberChains") < 2)
                    {
                        PlayerPrefs.SetInt("NumberChains", 2);
                    }
                    SceneManager.LoadScene("Fruta");

                }
            }
        }
    }
}
