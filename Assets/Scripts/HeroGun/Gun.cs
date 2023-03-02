using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    public Transform firepoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
       
        GameObject bull = Instantiate(bullet, firepoint.position, firepoint.rotation);
        // get the rigidbody component of the bullet object
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * 20;
        /*rb.AddForce(transform.up * 20, ForceMode2D.Impulse);*/
    }
}
