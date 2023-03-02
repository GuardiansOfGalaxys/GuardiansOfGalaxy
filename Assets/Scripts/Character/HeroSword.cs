
using UnityEngine;

public class HeroSword : Character 
{
    public HeroSword(GameObject gameObject) : base(gameObject)
    {
        health = 15;
        damage = 12;
        speed = 6;
        speedAttack = 1f;
    }
}