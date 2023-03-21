
using UnityEngine;

public class HeroGun : Character
{
    public HeroGun(GameObject gameObject) : base(gameObject)
    {
        health = 12;
        currentHealth = health;
        damage = 15;
        speed = 10;
        oldSpeed = speed;
        speedAttack = 0.75f;
        //Debug.Log("he:" + health + " dama:" + damage + " speed:" + speed + " speedAttack" + speedAttack);
    }
}

