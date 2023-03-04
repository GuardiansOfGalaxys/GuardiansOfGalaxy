using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class CharacterEnermy
{
    public int health { get; set; }
    public float speed { get; set; }
    public float damage { get; set; }

    public float speedAttack { get; set; }
    public Rigidbody2D body { get; set; }

    public Animator animator { get; set; }

    public BoxCollider2D boxCollider2D { get; set; }

    

    public CharacterEnermy(GameObject gameObject)
    {
        health = 10;
        damage = 2;
        speedAttack = 0;
        body = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
    }

    private void Move()
    {
        
    }
}
