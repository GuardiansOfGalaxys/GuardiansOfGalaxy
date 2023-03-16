using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{
    Character player;
    HUD hud;
    MapController mapController;
    ItemController itemController;
    float spawnItemTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = InitPlayer.player;
        mapController = player.mapController;
        itemController = player.itemController;
        hud = FindObjectOfType<HUD>(); ;
        mapController.addMapToList();
        addHealthBar();
    }

    // Update is called once per frame
    void Update()
    {
        player.Update();
        spawnItem();
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

    private void spawnItem()
    {
        spawnItemTime += Time.deltaTime;
        Vector3 spawnPos = player.camera.ViewportToWorldPoint(new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), 0));
        spawnPos.z = 0f;
        if (spawnItemTime >= 10f)
        {
            itemController.spawnItem(spawnPos);
            spawnItemTime = 0f;
        }
        mapController.tilemaps.ForEach(tilemap =>
        {
            TileBase tile = tilemap.GetTile(tilemap.WorldToCell(spawnPos));
            if (tile != null)
            {
                if(tile.name.Contains(Const.Item.Heal.name) || tile.name.Contains(Const.Item.Ghost.name))
                    Debug.Log("tilemap: " + tilemap + " contain: " + tile.name);
            }
        });
    }

    private void addToListOfMap(GameObject gameObject)
    {

    }

    private void addHealthBar()
    {
        hud.healthBar.maxValue = player.health;
        hud.player = player;
        player.currentHealth = (int) hud.healthBar.maxValue;
    }

    
}