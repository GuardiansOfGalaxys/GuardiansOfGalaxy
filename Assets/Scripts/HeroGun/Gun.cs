using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    public GameObject bullet;
    [SerializeField]
    public Transform firePoint;

    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            
        }
    }
    void Shoot()
    {
        GameObject bull = Instantiate(bullet, firePoint.position, firePoint.rotation);
        // get the rigidbody component of the bullet object
        Rigidbody2D rb = bull.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        AudioManager.Play(AudioClipName.BurgerShot);
    }
}
