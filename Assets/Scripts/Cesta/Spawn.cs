using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //Variable del nuevo objeto que queremos crear
    public GameObject asteroid;
    
    
    
    void FixedUpdate()
    {
        //Añadimos una probabilidad para crear un objeto y lo creamos cuando suceda
        if (Random.Range(0, 100) < 5)
        {
            
            GameObject a = Pool.singleton.Get("Asteroid");
            if(a != null)
            {
                a.transform.position = this.transform.position + new Vector3(Random.Range(-2, 2), 0, 0);
                a.SetActive(true);
            }
            //En caso de que ya haya el maximo de objetos te genera mas
            else
            {
                Pool.singleton.pooledItems.Add(Instantiate(asteroid, this.transform.position + new Vector3(Random.Range(-2, 2), 0, 0), Quaternion.identity));
            }
        }

    }
}
