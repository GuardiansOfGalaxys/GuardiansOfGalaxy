using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private int damage = 12;

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.TryGetComponent<Enermy>(out Enermy enermyComponent))
        {
            enermyComponent.TakeDamage(damage);
        }
    }
}
