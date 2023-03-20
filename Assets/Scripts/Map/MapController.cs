using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapController : MonoBehaviour
{
    public Tilemap tilemapMiddle;
    public Tilemap tilemapTop;
    public Tilemap tilemapTopLeft;
    public Tilemap tilemapTopRight;
    public Tilemap tilemapBottom;
    public Tilemap tilemapBottomLeft;
    public Tilemap tilemapBottomRight;
    public Tilemap tilemapLeft;
    public Tilemap tilemapRight;
    public List<Tilemap> tilemaps;
    readonly float xOffset = (float)Const.Map.x;
    readonly float yOffset = (float)Const.Map.y;
    readonly float moveMapSpeed = (float)Const.Map.moveSpeed;

    private void Start()
    {
        Debug.Log("start map");
        AddMapToList();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("abc");
        if (collider.CompareTag("MapTrigger"))
        {
            //BeforeMove();
            MoveMap();
            MoveObject();
        }
        
    }

    public void AddMapToList()
    {
        tilemaps.Add(tilemapTop);
        tilemaps.Add(tilemapMiddle);
        tilemaps.Add(tilemapBottom);
        tilemaps.Add(tilemapLeft);
        tilemaps.Add(tilemapRight);
        tilemaps.Add(tilemapTopLeft);
        tilemaps.Add(tilemapTopRight);
        tilemaps.Add(tilemapBottomLeft);
        tilemaps.Add(tilemapBottomRight);
    }

    private void BeforeMove()
    {
        tilemaps.ForEach(tilemap =>
        {
            Vector3 tilemapPos = tilemap.transform.position;
            List<GameObject> objectsInMap = tilemap.GetComponent<Map>().objectsInMap;
            objectsInMap.ForEach(o =>
            {

            });
            
        });

    }

    private void MoveMap()
    {
        MoveMapBaseOnCurrentMap(tilemapTop, new Vector3(0, yOffset, 0));
        tilemapTopLeft.transform.position = transform.position + new Vector3(-xOffset, yOffset, 0);
        tilemapTopRight.transform.position = transform.position + new Vector3(xOffset, yOffset, 0);
        tilemapLeft.transform.position = transform.position + new Vector3(-xOffset, 0, 0);
        tilemapRight.transform.position = transform.position + new Vector3(xOffset, 0, 0);
        MoveMapBaseOnCurrentMap(tilemapBottom, new Vector3(0, -yOffset, 0));
        //tilemapBottom.transform.position = transform.position + new Vector3(0, -yOffset, 0);
        tilemapBottomLeft.transform.position = transform.position + new Vector3(-xOffset, -yOffset, 0);
        tilemapBottomRight.transform.position = transform.position + new Vector3(xOffset, -yOffset, 0);
    }

    private void MoveMapBaseOnCurrentMap(Tilemap tilemap, Vector3 vectorOffset)
    {
        tilemap.GetComponent<Map>().vectorMove = transform.position + vectorOffset - tilemap.transform.position;
        tilemap.transform.position = transform.position + vectorOffset;
    }

    private void MoveObject()
    {
        tilemaps.ForEach(tilemap =>
        {
            Map map = tilemap.GetComponent<Map>();
            //List<GameObject> objectsInMap = map.objectsInMap;
            map.objectsInMap.ForEach(o =>
            {
                o.transform.position += map.vectorMove;
            });
        });
    }

    public void MoveMap(GameObject currentMap, Vector3 playerPos)
    {
        if (playerPos.x < currentMap.transform.position.x - xOffset / 2)
        {
            Move(currentMap, new Vector3(1, 0, 0));
            return;
        }
        if (playerPos.x > currentMap.transform.position.x + xOffset / 2)
        {
            Move(currentMap, new Vector3(-1, 0, 0));
            return;
        }
        if (playerPos.y < currentMap.transform.position.y - yOffset / 2)
        {
            Move(currentMap, new Vector3(0, 1, 0));
            return;
        }
        if (playerPos.y > currentMap.transform.position.y + yOffset / 2)
        {
            Move(currentMap, new Vector3(0, -1, 0));
            return;
        }

    }

    public void Move(GameObject currentMap, Vector3 direction)
    {
        List<Tilemap> tilemaps = new();
        Dictionary<Tilemap, Vector3> tilemapAndVector = new();
       // Debug.Log(tilemapBottom.cellBounds);
        if (direction.x > 0)
        {
            if (currentMap.name.Equals(Const.Map.tilemapTopRight) || currentMap.name.Equals(Const.Map.tilemapRight) || currentMap.name.Equals(Const.Map.tilemapBottomRight))
            {
                tilemaps.Add(tilemapTopLeft);
                tilemaps.Add(tilemapLeft);
                tilemaps.Add(tilemapBottomLeft);
            }
            else if (currentMap.name.Equals(Const.Map.tilemapTop) || currentMap.name.Equals(Const.Map.tilemapMiddle) || currentMap.name.Equals(Const.Map.tilemapBottom))
            {
                tilemaps.Add(tilemapTopRight);
                tilemaps.Add(tilemapRight);
                tilemaps.Add(tilemapBottomRight);
            }
            else
            {
                tilemaps.Add(tilemapTop);
                tilemaps.Add(tilemapMiddle);
                tilemaps.Add(tilemapBottom);
            }
        }
        if (direction.x < 0)
        {
            if (currentMap.name.Equals(Const.Map.tilemapTopRight) || currentMap.name.Equals(Const.Map.tilemapRight) || currentMap.name.Equals(Const.Map.tilemapBottomRight))
            {
                tilemaps.Add(tilemapTop);
                tilemaps.Add(tilemapMiddle);
                tilemaps.Add(tilemapBottom);
            }
            else if (currentMap.name.Equals(Const.Map.tilemapTop) || currentMap.name.Equals(Const.Map.tilemapMiddle) || currentMap.name.Equals(Const.Map.tilemapBottom))
            {
                tilemaps.Add(tilemapTopLeft);
                tilemaps.Add(tilemapLeft);
                tilemaps.Add(tilemapBottomLeft);
            }
            else
            {
                tilemaps.Add(tilemapTopRight);
                tilemaps.Add(tilemapRight);
                tilemaps.Add(tilemapBottomRight);
            }
        }
        if (direction.y > 0)
        {
            if (currentMap.name.Equals(Const.Map.tilemapTopLeft) || currentMap.name.Equals(Const.Map.tilemapTop) || currentMap.name.Equals(Const.Map.tilemapTopRight))
            {
                tilemaps.Add(tilemapBottomLeft);
                tilemaps.Add(tilemapBottom);
                tilemaps.Add(tilemapBottomRight);
            }
            else if (currentMap.name.Equals(Const.Map.tilemapLeft) || currentMap.name.Equals(Const.Map.tilemapMiddle) || currentMap.name.Equals(Const.Map.tilemapRight))
            {
                tilemaps.Add(tilemapTopLeft);
                tilemaps.Add(tilemapTop);
                tilemaps.Add(tilemapTopRight);
            }
            else
            {
                tilemaps.Add(tilemapLeft);
                tilemaps.Add(tilemapMiddle);
                tilemaps.Add(tilemapRight);
            }
        }
        if (direction.y < 0)
        {
            if (currentMap.name.Equals(Const.Map.tilemapTopLeft) || currentMap.name.Equals(Const.Map.tilemapTop) || currentMap.name.Equals(Const.Map.tilemapTopRight))
            {
                tilemaps.Add(tilemapLeft);
                tilemaps.Add(tilemapMiddle);
                tilemaps.Add(tilemapRight);
            }
            else if (currentMap.name.Equals(Const.Map.tilemapLeft) || currentMap.name.Equals(Const.Map.tilemapMiddle) || currentMap.name.Equals(Const.Map.tilemapRight))
            {
                tilemaps.Add(tilemapBottomLeft);
                tilemaps.Add(tilemapBottom);
                tilemaps.Add(tilemapBottomRight);
            }
            else
            {
                tilemaps.Add(tilemapTopLeft);
                tilemaps.Add(tilemapTop);
                tilemaps.Add(tilemapTopRight);
            }
        }
        Move(tilemaps, direction);
    }

    public void Move(List<Tilemap> tilemaps, Vector3 direction)
    {
        tilemaps.ForEach(tilemap => tilemap.transform.position += (new Vector3(direction.x * xOffset, direction.y * yOffset, 0) * 3));
    }

    public void Move(Dictionary<Tilemap, Vector3> tilemapsAndVectors, Vector3 currentMapPos)
    {
        foreach (KeyValuePair<Tilemap, Vector3> tilemapAndVector in tilemapsAndVectors)
        {
            tilemapAndVector.Key.transform.position = currentMapPos + tilemapAndVector.Value;
        }
    }
}
