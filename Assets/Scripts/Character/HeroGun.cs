
using UnityEngine;

public class HeroGun : Character
{
    public HeroGun(GameObject gameObject) : base(gameObject)
    {
        health = 10;
        currentHealth = health;
        damage = 15;
        speed = 6;
        oldSpeed = speed;
        speedAttack = 0.75f;
    }
}

