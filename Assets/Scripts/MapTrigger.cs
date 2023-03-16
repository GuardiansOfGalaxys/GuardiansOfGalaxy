using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapTrigger : MonoBehaviour
{
    Character player;
    MapController mapController;
    ItemController itemController;
    bool isMapMoved = true;
    float spawnItemTime = 0;

    private void Start()
    {
        player = InitPlayer.player;
        mapController = player.mapController;
        itemController = player.itemController;
        isMapMoved = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tilemap"))
        {
            if (isMapMoved) return;
            mapController.MoveMap(collision.GetComponent<Tilemap>().gameObject, player.transform.position);
        }
    }
}
