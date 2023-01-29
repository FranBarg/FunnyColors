using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ImageController : MonoBehaviour
{
    Image _image;
    // Start is called before the first frame update
    void Start()
    {
        _image = this.GetComponent<Image>();
        _image.enabled = false;
    }

    public void SetImage(GameObject go)
    {
        _image.enabled = true;
        Invoke("TurnOff", 2);
    }
    void TurnOff()
    {
        _image.enabled = false;
    }
}
