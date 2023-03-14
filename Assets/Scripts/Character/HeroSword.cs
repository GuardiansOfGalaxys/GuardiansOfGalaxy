
using UnityEngine;

public class HeroSword : Character 
{
    public HeroSword(GameObject gameObject) : base(gameObject)
    {
        health = 15;
        damage = 12;
        speed = 3;
        speedAttack = 1f;
        Debug.Log("he:" + health + " dama:"+ damage+" speed:" + speed+ " speedAttack"+ speedAttack);
    }
}