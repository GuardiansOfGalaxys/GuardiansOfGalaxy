using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Character player;

    public GameObject hitEffect;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    gameObject.GetComponent<Rigidbody2D>().velocity = transform.up * player.speedAttack;

    //    Destroy(gameObject, 2);
    //}

    void OnCollisionEnter2D(Collision2D collision)
    {
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 2f);
        Destroy(gameObject);
    }
}
