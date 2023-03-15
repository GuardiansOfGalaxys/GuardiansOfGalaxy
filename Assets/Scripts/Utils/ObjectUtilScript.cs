using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectUtilScript : MonoBehaviour
{
    public static GameObject SpawnObjects(Dictionary<GameObject, float> dictionaryGameObjectAndRate, Vector3 spawnPos)
    {
        ICollection<float> rates = dictionaryGameObjectAndRate.Values;
        if (rates.Sum() > 1)
            return null;
        float random = Random.Range(0f, 1f);
        float i = 0f;
        foreach (KeyValuePair<GameObject, float> gameObjectAndRate in dictionaryGameObjectAndRate)
        {
            i += gameObjectAndRate.Value;
            if (random <= i)
            {
                return Instantiate(gameObjectAndRate.Key, spawnPos, Quaternion.identity);
            }
        }
        return null;
    }

    public static Dictionary<GameObject, float> AddToDictionary(List<GameObject> gameObjects, List<float> rates)
    {
        Dictionary<GameObject, float> dictionaryGameObjectAndRate = new();
        if (gameObjects.Count != rates.Count)
        {
            Debug.Log("The number of key is not equal to value!");
        }
        for (int i = 0; i < gameObjects.Count; i++)
        {
            dictionaryGameObjectAndRate.Add(gameObjects[i], rates[i]);
        }
        return dictionaryGameObjectAndRate;
    }
}
