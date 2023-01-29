using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyInvis : MonoBehaviour
{
    Scene currentScene;
    string sceneName;

    private void Start()
    {

        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

    }

    private void OnMouseDown()
    {
        if (sceneName == "Tocar")
        {
            GameManager.singleton.PlaySound("disparo");

            GameManager.singleton.Points = GameManager.singleton.Points + 1;
            this.gameObject.SetActive(false);
        }
            
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.singleton.PlaySound("cesta");

            GameManager.singleton.Points = GameManager.singleton.Points + 1;
            //Destroy(collision.gameObject);
            this.gameObject.SetActive(false);
        } else if (collision.gameObject.tag == "Blocker")
        {
            this.gameObject.SetActive(false);
        }
    }
}
