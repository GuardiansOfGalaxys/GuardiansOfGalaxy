using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
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
        spawnTime += Time.deltaTime;
        Vector3 spawnPos = camera.ViewportToWorldPoint(new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), 0));
        spawnPos.z = 0f;
        if(spawnTime >= 10f)
        {
            GameObject newObject =  ObjectUtilScript.SpawnObjects(dictionaryGameObjectAndRate, spawnPos);
            newObject.AddComponent<Item>();
            items.Add(newObject);
            spawnTime = 0f;
        }
    }

    

}
