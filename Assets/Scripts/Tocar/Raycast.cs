using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    // Start is called before the first frame update
    //private void FixedUpdate()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        RaycastHit hit;
    //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    //        if (Physics.Raycast(ray, out hit, 100f))
    //        {
    //            if (hit.transform != null)
    //            {
    //                Rigidbody2D rb;

    //                if (rb = hit.transform.GetComponent<Rigidbody2D>())
    //                {
    //                    this.gameObject.SetActive(false);

    //                }

    //            }
    //        }
    //    }
    //}

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }
}
