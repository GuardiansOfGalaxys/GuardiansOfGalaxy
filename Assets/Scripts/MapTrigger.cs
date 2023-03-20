using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapTrigger : MonoBehaviour
{
    Character player;
    MapController mapController;
    bool isMapMoved = true;

    private void Start()
    {
        player = InitPlayer.player;
        mapController = player.mapController;
        isMapMoved = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tilemap"))
        {
            if (isMapMoved) return;
            Debug.Log(collision.name);
           // mapController.MoveMap(collision.GetComponent<Tilemap>().gameObject, player.transform.position);
        }
    }
}
