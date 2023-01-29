using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event", menuName = "Game Event", order = 52)]
public class Event : ScriptableObject
{
    //Lista de escuchadores de eventos
    private List<ListernerEvent> listeners = new List<ListernerEvent>();

    //Método que registra en la lista los escuchadores
    public void Register(ListernerEvent listener)
    {
        listeners.Add(listener);
    }

    //Método que borra los escuchadores de la lista
    public void Unregister(ListernerEvent listener)
    {
        listeners.Remove(listener);
    }

    //Recorre la lista de escuchadores y ejecuta el método de los eventos para cada listener
    public void Ocurred(GameObject go)
    {
        for(int i = 0; i < listeners.Count; i++)
        {
            listeners[i].OnEventOccurs(go);
        }
    }
}
