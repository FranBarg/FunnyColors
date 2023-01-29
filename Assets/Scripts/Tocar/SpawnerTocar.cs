using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTocar : MonoBehaviour
{
    public GameObject asteroid;

    public float minForce, maxForce;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 100) < 5)
        {
            //Instantiate(asteroid, this.transform.position + new Vector3(Random.Range(-10, 10), 0, 0), Quaternion.identity);
            GameObject a = Pool.singleton.Get("Asteroid");
            if (a != null)
            {
                a.transform.position = this.transform.position + new Vector3(Random.Range(-2, 2), 0, 0);
                a.SetActive(true);

                if(a.transform.position.x < 0)
                {
                    direction.x = Random.Range(0f, 0.2f);
                }
                else
                {
                    direction.x = Random.Range(-0.2f, 0f);
                }
                
                
                float forceMagnitude = Random.Range(minForce, maxForce);
                Vector3 force = Vector3.Normalize(direction)*forceMagnitude;

                a.GetComponent<Rigidbody2D>().AddForce(force);
            }
            else
            {
                Pool.singleton.pooledItems.Add(Instantiate(asteroid, this.transform.position + new Vector3(Random.Range(-2, 2), 0, 0), Quaternion.identity));
            }
        }

    }
}
