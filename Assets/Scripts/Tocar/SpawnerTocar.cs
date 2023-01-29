using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTocar : MonoBehaviour
{    
    //Variable del nuevo objeto que queremos crear

    public GameObject asteroid;
    //Asignamos variable para obtener una fuerza minima y maxima, ademas de asignar la direccion que va a llevar el objeto
    public float minForce, maxForce;
    public Vector3 direction;
    

    
    void Update()
    {
        //Añadimos una probabilidad para crear un objeto y lo creamos cuando suceda
        if (Random.Range(0, 100) < 5)
        {
            
            GameObject a = Pool.singleton.Get("Asteroid");
            if (a != null)
            {
                a.transform.position = this.transform.position + new Vector3(Random.Range(-2, 2), 0, 0);
                a.SetActive(true);
                //Le damos al objeto una direccion aleatoria
                if(a.transform.position.x < 0)
                {
                    direction.x = Random.Range(0f, 0.2f);
                }
                else
                {
                    direction.x = Random.Range(-0.2f, 0f);
                }
                
                //Asignamos una fuerza aleatoria entre la fuerza minima y maximas, ademas de aplicarse en la direccion
                
                float forceMagnitude = Random.Range(minForce, maxForce);
                Vector3 force = Vector3.Normalize(direction)*forceMagnitude;
                //Otorgamos la fuerza al objeto
                a.GetComponent<Rigidbody2D>().AddForce(force);
            }

            //En caso de que ya haya el maximo de objetos te genera mas
            else
            {
                Pool.singleton.pooledItems.Add(Instantiate(asteroid, this.transform.position + new Vector3(Random.Range(-2, 2), 0, 0), Quaternion.identity));
            }
        }

    }
}
