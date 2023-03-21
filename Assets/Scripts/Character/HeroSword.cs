
using UnityEngine;

public class HeroSword : Character 
{
    public HeroSword(GameObject gameObject) : base(gameObject)
    {
        health = 15;
        currentHealth = health;
        damage = 12;
        speed = 8;
        oldSpeed = speed;
        speedAttack = 1f;
        Debug.Log("he:" + health + " dama:"+ damage+" speed:" + speed+ " speedAttack"+ speedAttack);
    }
}