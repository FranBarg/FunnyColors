using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    
    //Desactivamos el objeto al tocarlos
    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }
}
