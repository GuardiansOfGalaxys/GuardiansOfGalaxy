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
        Debug.Log(random);
    }
    Vector3 Gennerate()
    {
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        // save screen edges in world coordinates
        float screenZ = -Camera.main.transform.position.z;
        Vector3 lowerLeftCornerScreen = new Vector3(0, 0, screenZ);
        Vector3 upperRightCornerScreen = new Vector3(screenWidth, screenHeight, screenZ);
        Vector3 lowerLeftCornerWorld = Camera.main.ScreenToWorldPoint(lowerLeftCornerScreen);
        Vector3 upperRightCornerWorld = Camera.main.ScreenToWorldPoint(upperRightCornerScreen);
        float screenLeft = lowerLeftCornerWorld.x;
        float screenRight = upperRightCornerWorld.x;
        float screenTop = upperRightCornerWorld.y;
        float screenBottom = lowerLeftCornerWorld.y;
        return new Vector3(Random.Range(screenLeft, screenRight), Random.Range(screenBottom, screenTop), -Camera.main.transform.position.z);
    }
}
