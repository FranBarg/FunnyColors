using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckWin : MonoBehaviour
{
    public GameObject[] mySprites;   // Start is called before the first frame update
    public bool heGanado = false;
    public float time, timeMax;
    public bool end;
    public Event youWin;

    void Start()
    {
        mySprites = GameObject.FindGameObjectsWithTag("PaintedObject");
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < mySprites.Length; i++)
        {
            heGanado = true;
            if(mySprites[i].GetComponent<SpriteRenderer>().color != mySprites[i].GetComponent<CorrectColor>().colorCorrecto)
            {
                heGanado = false;
                Debug.Log("Aun no he ganado");
                return;
            }

        }
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

                SceneManager.LoadScene("Fruta");

            }
            
        }
       



    }
}
