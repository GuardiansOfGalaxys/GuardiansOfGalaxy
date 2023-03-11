using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enermy : MonoBehaviour
{

    public float speed = 3f;
    private Transform target;
    private float distance;

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

        //transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        distance = Vector2.Distance(transform.position, target.position);
        Vector2 direction = target.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.position = Vector2.MoveTowards(this.transform.position, target.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
    }
    
}
