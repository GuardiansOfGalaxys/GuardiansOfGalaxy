using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Map : MonoBehaviour
{
    public List<GameObject> objectsInMap = new();
    public Vector3 vectorMove;

    public void AddToList(GameObject gameObject)
    {
        objectsInMap.Add(gameObject);
    }

    public void RemoveOnList(GameObject gameObject)
    {
        objectsInMap.Remove(gameObject);
    }
}
