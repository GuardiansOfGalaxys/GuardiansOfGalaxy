using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

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

    public float speed = 1.0f;
    private Transform target;

    //public static List<EnermyS> lstEner= new List<EnermyS>();
    // Start is called before the first frame update
    void Start()
    {
        target = Camera.main.transform;
        // lstEner = SpawnEnermy.lstEnermy;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    //public void OnTriggerEnter2D(Collider2D collision)
    //{
    //}
}
