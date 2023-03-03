
using UnityEngine;

public class HeroGun : Character
{
    public HeroGun(GameObject gameObject) : base(gameObject)
    {
        health = 10;
        damage = 15;
        speed = 6;
        speedAttack = 0.75f;
    }

}

