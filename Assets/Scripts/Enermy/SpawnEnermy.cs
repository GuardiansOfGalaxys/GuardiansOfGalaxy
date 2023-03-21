using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class EnermyS
{
    public float PosX { get; set; }
    public float PosY { get; set; }
    public float PosZ { get; set; }
    public int type { get; set; }
    public EnermyS(float posX, float posY, float posZ, int type)
    {
        PosX = posX;
        PosY = posY;
        PosZ = posZ;
        this.type = type;
    }
}
public class SpawnEnermy : MonoBehaviour
{
    [SerializeField]
    public GameObject enemyLv1Prefab;
    [SerializeField]
    public GameObject enemyLv2Prefab;
    [SerializeField]
    public GameObject enemyLv3Prefab;
    public bool isPlay = false;
    private Camera mainCamera;
    //TimerEnermySpawn timerES;

    public static List<EnermyS> lstEnermy = new List<EnermyS>();
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;

    }

    public GameObject SpawnObject()
    {

        GameObject a;
        //Vector3 viewportCenter = new Vector3(0.5f, 0.5f, 0f); // Tọa độ tâm của viewport
        float distance = 8f; // Khoảng cách mong muốn giữa quái và tâm của viewport
        //Vector3 randomOffset = Random.insideUnitCircle.normalized * distance; // Vector có độ dài bằng distance và hướng ngẫu nhiên
        Vector3 randomPosition;
        float distanceToViewportCenter;
        while (true)
        {
            randomPosition = mainCamera.ViewportToWorldPoint(new Vector3(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 0));
            distanceToViewportCenter = Vector3.Distance(randomPosition, mainCamera.ViewportToWorldPoint(new Vector3(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 0)));
            if (distanceToViewportCenter > distance) break;
        }

        //Vector3 randomPosition = mainCamera.ViewportToWorldPoint(new Vector3(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 0));

        int random = Random.Range(0, 10);

            if (random >= 0 && random <= 4)
            {
                a = Instantiate(enemyLv1Prefab, randomPosition, Quaternion.identity);
                // lstEnermy.Add(new EnermyS(a.transform.position.x, a.transform.position.y, 0, 1));

            }
            else if (random >= 5 && random <= 7)
            {
                a = Instantiate(enemyLv2Prefab, randomPosition, Quaternion.identity);
                // lstEnermy.Add(new EnermyS(a.transform.position.x, a.transform.position.y, 0, 2));
            }
            else
            {
                a = Instantiate(enemyLv3Prefab, randomPosition, Quaternion.identity);
                //lstEnermy.Add(new EnermyS(a.transform.position.x, a.transform.position.y, 0, 3));

            }


        //Debug.Log(random);
        //Debug.Log("Distance to viewport center: " + distanceToViewportCenter);
        return a;

    }
    
}
