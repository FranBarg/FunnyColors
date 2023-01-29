using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PoolItem
{
    //Variables para crear la pool
    public GameObject prefab;
    public int amount;
    public bool expandable;
}
public class Pool : MonoBehaviour
{
    //Generamos una lista de objetos que queremos generar y los objetos generados
    public List<PoolItem> items;
    public List<GameObject> pooledItems;

    public static Pool singleton;

    private void Awake()
    {
        singleton = this;   
    }

    
    void Start()
    {
        //Generamos una nueva lista para los objetos guardados
        pooledItems = new List<GameObject>();
        //Generamos los objetos listados
        foreach(PoolItem item in items)
        {
            for(int i=0; i<item.amount; i++)
            {
                GameObject obj = Instantiate(item.prefab);
                obj.SetActive(false);
                pooledItems.Add(obj);
            }
        }
    }
    //Creamos un accesor
    public GameObject Get(string tag)
    {
        for (int i = 0; i < pooledItems.Count; i++)
        {
            if (!pooledItems[i].activeInHierarchy && pooledItems[i].tag == tag)
            {
                return pooledItems[i];
            }
        }
        return null;
    }

}
