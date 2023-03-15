using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapTrigger : MonoBehaviour
{
    public Tilemap currentMap;
    public Tilemap tileMapTop;
    public Tilemap tileMapTopLeft;
    public Tilemap tileMapTopRight;
    public Tilemap tileMapBottom;
    public Tilemap tileMapBottomLeft;
    public Tilemap tileMapBottomRight;
    public Tilemap tileMapLeft;
    public Tilemap tileMapRight;
    public static List<GameObject> itemsInTileMapTop;
    public static List<GameObject> itemsInTileMapTopTopLeft;
    public static List<GameObject> itemsInTileMapTopRight;
    public static List<GameObject> itemsInTileMapBottom;
    public static List<GameObject> itemsInTileMapBottomLeft;
    public static List<GameObject> itemsInTileMapBottomRight;
    public static List<GameObject> itemsInTileMapLeft;
    public static List<GameObject> itemsInTileMapRight;
    readonly float xOffset = (float)Const.Map.x;
    readonly float yOffset = (float)Const.Map.y;
    readonly float moveMapSpeed = (float)Const.Map.moveSpeed;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("MapTrigger"))
        {
            MoveMap();
        }

    }

    public void MoveMap()
    {
        Vector3 currentMapPos = currentMap.transform.position;
        tileMapTop.transform.position = transform.position + new Vector3(0, yOffset, 0);
        //itemsInTileMapTop.ForEach(item => item.transform.position += new Vector3(0, 2 * yOffset, 0));
        tileMapTopLeft.transform.position = transform.position + new Vector3(-xOffset, yOffset, 0);
        tileMapTopRight.transform.position = transform.position + new Vector3(xOffset, yOffset, 0);
        tileMapBottom.transform.position = transform.position + new Vector3(0, -yOffset, 0);
        tileMapBottomLeft.transform.position = transform.position + new Vector3(-xOffset, -yOffset, 0);
        tileMapBottomRight.transform.position = transform.position + new Vector3(xOffset, -yOffset, 0);
        tileMapLeft.transform.position = transform.position + new Vector3(-xOffset, 0, 0);
        tileMapRight.transform.position = transform.position + new Vector3(xOffset, 0, 0);
    }
}
