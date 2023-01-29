using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candado : MonoBehaviour
{
    public GameObject chain, chain2;
    
    
    void Update()
    {
        //accedemos a memoria para desactivar los candados
        if (PlayerPrefs.GetInt("NumberChains") == 1)
        {
            chain.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("NumberChains") == 2)
        {
            chain.SetActive(false);
            chain2.SetActive(false);
        }
        
    }
}
