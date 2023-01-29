using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyInvis : MonoBehaviour
{
    //Variables para guardar la escena
    Scene currentScene;
    string sceneName;

    private void Start()
    {
        //Asignamos a la variable el nombre de la escena
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

    }

    private void OnMouseDown()
    {
        if (sceneName == "Tocar")
        {
            //Activamos el sonido de disparos
            GameManager.singleton.PlaySound("disparo");
            //Suma 1 a la puntuacion y desactivamos el objeto
            GameManager.singleton.Points = GameManager.singleton.Points + 1;
            this.gameObject.SetActive(false);
        }
            
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Detectamos cuando el objeto choca con el player 
        if (collision.gameObject.tag == "Player")
        {
            //Activamos el sonido de la cesta
            GameManager.singleton.PlaySound("cesta");
            //sumamos 1 a la puntuacion
            GameManager.singleton.Points = GameManager.singleton.Points + 1;
            //Desactivamos el objeto
            this.gameObject.SetActive(false);
        } 
        //Detectamos cuando chocha con un bloqueador para desactivar el objeto
        else if (collision.gameObject.tag == "Blocker")
        {
            this.gameObject.SetActive(false);
        }
    }
}
