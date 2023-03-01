using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTrigger : MonoBehaviour
{
    public Transform currentMap;
    public Transform player;
    public List<Transform> listTargetLeft;
    public List<Transform> listTargetRight;
    public List<Transform> listTargetTop;
    public List<Transform> listTargetBottom;
    public float xOffset = 0f;
    public float yOffset = 0f;
    public float moveMapSpeed = 100f;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("MapTrigger"))
        {
            MoveMap();
        }

    }

    private void MoveMap()
    {
        if (MapIsMoved()) return;
        Vector3 newPos;
        if (player.position.x < currentMap.position.x)
        {
            listTargetRight.ForEach(t =>
            {
                newPos = new Vector3(currentMap.position.x + xOffset, t.position.y, 0f);
                t.position = Vector3.Slerp(t.position, newPos, moveMapSpeed * Time.deltaTime);
            });
        }
        if (player.position.x > currentMap.position.x)
        {
            listTargetLeft.ForEach(t =>
            {
                newPos = new Vector3(currentMap.position.x - xOffset, t.position.y, 0f);
                t.position = Vector3.Slerp(t.position, newPos, moveMapSpeed * Time.deltaTime);
            });
        }
        if (player.position.y > currentMap.position.y)
        {
            listTargetBottom.ForEach(t =>
            {
                newPos = new Vector3(t.position.x, currentMap.position.y - yOffset, 0f);
                t.position = Vector3.Slerp(t.position, newPos, moveMapSpeed * Time.deltaTime);
            });
        }
        if (player.position.y < currentMap.position.y)
        {
            listTargetTop.ForEach(t =>
            {
                newPos = new Vector3(t.position.x, currentMap.position.y + yOffset, 0f);
                t.position = Vector3.Slerp(t.position, newPos, moveMapSpeed * Time.deltaTime);
            });
        }
    }

    private bool MapIsMoved()
    {
        return currentMap.position.x > listTargetLeft[0].position.x
            && currentMap.position.x < listTargetRight[0].position.x
            && currentMap.position.y < listTargetTop[0].position.y
            && currentMap.position.y > listTargetBottom[0].position.y;
    }
}
