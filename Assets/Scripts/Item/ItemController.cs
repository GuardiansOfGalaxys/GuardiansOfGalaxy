using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    float spawnTime;
    public new Camera camera;

    private Dictionary<GameObject, float> dictionaryGameObjectAndRate;
    public List<GameObject> gameObjects;
    public List<float> rates;
    public static List<GameObject> items;

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = 0f;
        dictionaryGameObjectAndRate = ObjectUtilScript.AddToDictionary(gameObjects, rates);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnItem(Vector3 spawnPos)
    {
        GameObject newObject = ObjectUtilScript.SpawnObjects(dictionaryGameObjectAndRate, spawnPos);
        Debug.Log(newObject);
        //items.Add(newObject);
        spawnTime = 0f;
    }

    

}
