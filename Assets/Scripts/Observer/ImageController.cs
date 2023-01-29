using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ImageController : MonoBehaviour
{
    //Variable de la imagen
    Image _image;
    
    void Start()
    {
        //Obtenemos el componente image, lo asignamos a la variable y lo desactivamos
        _image = this.GetComponent<Image>();
        _image.enabled = false;
    }

    //Funcion para activar el componente image cuando sea detectado por el observer
    public void SetImage(GameObject go)
    {
        _image.enabled = true;
        Invoke("TurnOff", 2);
    }
    //Funcion para desactivar el componente image cuando sea detectado por el observer
    void TurnOff()
    {
        _image.enabled = false;
    }
}
