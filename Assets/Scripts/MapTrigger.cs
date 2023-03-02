using System.Collections.Generic;
using UnityEngine;

public class MapTrigger : MonoBehaviour
{
    public Transform currentMap;
    public List<Transform> listTargetLeft;
    public List<Transform> listTargetRight;
    public List<Transform> listTargetTop;
    public List<Transform> listTargetBottom;
    readonly float xOffset = (float)EnumScript.Map.x;
    readonly float yOffset = (float)EnumScript.Map.y;
    readonly float moveMapSpeed = (float)EnumScript.Map.moveSpeed;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("MapTrigger"))
        {
            MoveMap();
        }

    }

    private void MoveMap()
    {
        Vector3 newPos;
        listTargetRight.ForEach(t =>
        {
            newPos = new Vector3(currentMap.position.x + xOffset, t.position.y, 0f);
            t.position = Vector3.Slerp(t.position, newPos, moveMapSpeed * Time.deltaTime);
        });
        listTargetLeft.ForEach(t =>
        {
            newPos = new Vector3(currentMap.position.x - xOffset, t.position.y, 0f);
            t.position = Vector3.Slerp(t.position, newPos, moveMapSpeed * Time.deltaTime);
        });
        listTargetBottom.ForEach(t =>
        {
            newPos = new Vector3(t.position.x, currentMap.position.y - yOffset, 0f);
            t.position = Vector3.Slerp(t.position, newPos, moveMapSpeed * Time.deltaTime);
        });
        listTargetTop.ForEach(t =>
        {
            newPos = new Vector3(t.position.x, currentMap.position.y + yOffset, 0f);
            t.position = Vector3.Slerp(t.position, newPos, moveMapSpeed * Time.deltaTime);
        });
    }
}
