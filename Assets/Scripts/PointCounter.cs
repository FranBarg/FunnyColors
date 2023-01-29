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
        GameManager.singleton.Points = 0;

        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "Puntos: " + GameManager.singleton.Points.ToString() + "/30";

        if (sceneName == "Tocar")
        {
            if (GameManager.singleton.Points >= 30)
            {
                if (!end)
                {
                    GameManager.singleton.PlaySound("win");

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
            if (GameManager.singleton.Points >= 30)
            {
                if (!end)
                {
                    GameManager.singleton.PlaySound("win");

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
                    SceneManager.LoadScene("Fruta");

                }
            }
        }
    }
}
