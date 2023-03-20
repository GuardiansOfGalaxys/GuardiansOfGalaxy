using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{
    public Character player;
    HUD hud;
    MapController mapController;
    ItemController itemController;
    float spawnItemTime = 0;
    readonly float xOffset = (float)Const.Map.x / 2;
    readonly float yOffset = (float)Const.Map.y / 2;
    // Start is called before the first frame update
    void Start()
    {
        player = InitPlayer.player;
        mapController = player.mapController;
        itemController = player.itemController;
        hud = FindObjectOfType<HUD>(); ;
        mapController.AddMapToList();
        AddHealthBar();
    }

    // Update is called once per frame
    void Update()
    {
        player.Update();

        SpawnItem();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            if (collision.name.Contains(Const.Item.Heal.name))
            {
                player.Heal();
            }
            if (collision.name.Contains(Const.Item.Ghost.name))
            {
                player.Ghost();
            }
            Destroy(collision.gameObject);
        }
    }

    private void SpawnItem()
    {
        spawnItemTime += Time.deltaTime;
        Vector3 spawnPos = player.camera.ViewportToWorldPoint(new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), 0));
        spawnPos.z = 0f;
        if (spawnItemTime >= 10f)
        {
            GameObject item = itemController.SpawnItem(spawnPos);
            spawnItemTime = 0f;
            AddToListOfMap(item);
        }
        
    }

    private Tilemap AddToListOfMap(GameObject gameObject)
    {
        foreach (Tilemap tilemap in mapController.tilemaps)
        {
            float xDiff = gameObject.transform.position.x - tilemap.transform.position.x;
            float yDiff = gameObject.transform.position.y - tilemap.transform.position.y;
            if (xDiff < xOffset && xDiff > -xOffset && yDiff < yOffset && yDiff > -yOffset)
            {
                Map map = tilemap.GetComponent<Map>();
                map.AddToList(gameObject);
                Debug.Log("add " + gameObject.name + " to map " + tilemap.name);
                return tilemap;
            }
        }
        return null;
    }


    private void AddHealthBar()
    {
        hud.healthBar.maxValue = player.health;
        hud.player = player;
        player.currentHealth = (int)hud.healthBar.maxValue;
    }


}