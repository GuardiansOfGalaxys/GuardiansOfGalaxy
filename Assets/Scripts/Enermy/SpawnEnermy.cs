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

    TimerEnermySpawn timerES;

    public static List<EnermyS> lstEnermy = new List<EnermyS>();
    // Start is called before the first frame update
    void Start()
    {
        timerES = gameObject.AddComponent<TimerEnermySpawn>();
        timerES.Duration = 0.2f;
        timerES.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerES.Finished) //&& isPlay == true)
        {
            SpawnObject();
            timerES.Duration = 0.2f;
            timerES.Run();
        }
    }

    private void SpawnObject()
    {
        GameObject a;
        int random = Random.Range(0, 10);

        if (random >= 0 && random <= 4)
        {
            a = Instantiate(enemyLv1Prefab, Gennerate(), Quaternion.identity);
            // lstEnermy.Add(new EnermyS(a.transform.position.x, a.transform.position.y, 0, 1));

        }
        else if (random >= 5 && random <= 7)
        {
            a = Instantiate(enemyLv2Prefab, Gennerate(), Quaternion.identity);
            // lstEnermy.Add(new EnermyS(a.transform.position.x, a.transform.position.y, 0, 2));
        }
        else
        {
            a = Instantiate(enemyLv3Prefab, Gennerate(), Quaternion.identity);
            //lstEnermy.Add(new EnermyS(a.transform.position.x, a.transform.position.y, 0, 3));

        }
    }
    Vector3 Gennerate()
    {
        Camera mainCamera = Camera.main;

        float cameraHeight = 2f * mainCamera.orthographicSize;
        float cameraWidth = cameraHeight * mainCamera.aspect;

        float xRange = cameraWidth / 2f;
        float yRange = cameraHeight / 2f;

        return new Vector3(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange), 0);
    }
}
