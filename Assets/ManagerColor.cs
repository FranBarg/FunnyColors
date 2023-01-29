using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManagerColor : MonoBehaviour
{
    public Color colorActivo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      // Al hacer click con el raton cambia de color el objeto al color guardado
        if (Input.GetMouseButtonDown(0))
        {

            GameManager.singleton.PlaySound("pintura");

            RaycastHit2D rayHit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
            Debug.Log(rayHit.transform.name);
            rayHit.transform.GetComponent<SpriteRenderer>().color = colorActivo;
        }
            

    }
    // Cambia el color guardado
    public void cambiarColorActivo (Image miImage)
    {
        colorActivo = miImage.color;

    }
}
