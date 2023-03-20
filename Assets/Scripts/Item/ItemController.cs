using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public new Camera camera;

    private Dictionary<GameObject, float> dictionaryGameObjectAndRate;
    public List<GameObject> gameObjects;
    public List<float> rates;

    // Start is called before the first frame update
    void Start()
    {
        dictionaryGameObjectAndRate = ObjectUtilScript.AddToDictionary(gameObjects, rates);
    }

    public GameObject SpawnItem(Vector3 spawnPos)
    {
        GameObject newObject = ObjectUtilScript.SpawnObjects(dictionaryGameObjectAndRate, spawnPos);
        newObject.AddComponent<Item>();
        return newObject;
    }

    

}
