using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float existenceTime { get; set; }

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

}
