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
    //}
}
