using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    public enum EnermyType
    {
        green,
        yellow,
        red
    }

    public EnermyType type;
    [SerializeField]
    public GameObject greenPrefab;
    [SerializeField]
    public GameObject yellowPrefab;
    [SerializeField]
    public GameObject redPrefab;
    [SerializeField]
    public GameObject explosivePrefab;

    //public static List<EnermyS> lstEner= new List<EnermyS>();
    // Start is called before the first frame update
    void Start()
    {
       // lstEner = SpawnEnermy.lstEnermy;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //public void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Vector3 position = Vector3.zero;
    //    if (collision.gameObject.tag == "Bullet")
    //    {
    //        if (type == EnermyType.green)
    //        {
    //            position = gameObject.transform.position;
    //            Destroy(gameObject);
    //            Instantiate(yellowPrefab, position, Quaternion.identity);
    //            foreach (var item in lstEner)
    //            {
    //                if (item.PosX == position.x &&
    //                    item.PosY == position.y)
    //                {
    //                    item.type = 2;
    //                }
    //            }
    //            Debug.Log("Here 1");
    //        }

    //        if (type == EnermyType.yellow)
    //        {
    //            position = gameObject.transform.position;
    //            Destroy(gameObject);
    //            Instantiate(redPrefab, position, Quaternion.identity);
    //            foreach (var item in lstEner)
    //            {
    //                if (item.PosX == position.x &&
    //                    item.PosY == position.y)
    //                {
    //                    item.type = 3;
    //                }
    //            }
    //            Debug.Log("Here 2");
    //        }
    //        if (type == EnermyType.red)
    //        {
    //            Instantiate(explosivePrefab, gameObject.transform.position, Quaternion.identity);
    //            foreach (var item in lstEner)
    //            {
    //                if (item.PosX == gameObject.transform.position.x && item.PosY == gameObject.transform.position.y)
    //                {
    //                    lstEner.Remove(item);
    //                    break;
    //                }
    //            }
    //            Debug.Log("Here 3");
    //            Destroy(gameObject);
    //        }

    //    }
    //}
}
