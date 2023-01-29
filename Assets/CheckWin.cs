using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckWin : MonoBehaviour
{
    public GameObject[] mySprites;   
    public bool heGanado = false;
    public float time, timeMax;
    public bool end;
    public Event youWin;

    void Start()
    {
        // Buscamos el objeto mediante su tag y lo asignamos a la variable
        mySprites = GameObject.FindGameObjectsWithTag("PaintedObject");
        
    }

    void Update()
    {
        //Bucle para detectar continuamente si hemos ganado o no
        for (int i = 0; i < mySprites.Length; i++)
        {
            heGanado = true;
            //Comprobamos si es el mismo color
            if(mySprites[i].GetComponent<SpriteRenderer>().color != mySprites[i].GetComponent<CorrectColor>().colorCorrecto)
            {
                heGanado = false;
                Debug.Log("Aun no he ganado");
                return;
            }

        }
        // Una vez a detectado que ha ganado activa la siguiente escena
        if(heGanado == true)
        {
            Debug.Log("He ganado");

            if (!end)
            {
                GameManager.singleton.PlaySound("win");

                youWin.Ocurred(this.gameObject);
                end = true;
            }

            time = time + Time.deltaTime;

            if (time >= timeMax)
            {
                if (PlayerPrefs.GetInt("NumberStars") < 1)
                {
                    PlayerPrefs.SetInt("NumberStars", 1);
                }
                if (PlayerPrefs.GetInt("NumberChains") < 1)
                {
                    PlayerPrefs.SetInt("NumberChains", 1);
                }
                SceneManager.LoadScene("Fruta");

            }
            
        }
       



    }
}
