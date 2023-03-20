using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Item : MonoBehaviour
{
    public float existenceTime { get; set; }
    public Tilemap tilemapContainItem;

    public Item()
    {
        this.existenceTime = 0f;
    }

    void Update()
    {
        this.existenceTime += Time.deltaTime;
        if (this.existenceTime >= Const.Map.existenceTimeItem)
        {
            Destroy(gameObject);
        }
    }

    public void OnDestroy()
    {
        tilemapContainItem.GetComponent<Map>().objectsInMap.Remove(gameObject);
    }

}
