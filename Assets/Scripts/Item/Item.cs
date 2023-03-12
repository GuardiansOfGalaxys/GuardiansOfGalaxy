using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float existenceTime { get; set; }

    public Item(GameObject objectItem)
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log(gameObject.name);
            Destroy(gameObject);
        }
    }


}
