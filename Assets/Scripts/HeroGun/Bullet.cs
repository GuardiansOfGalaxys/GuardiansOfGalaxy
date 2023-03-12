using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Bullet : MonoBehaviour
{
    GameObject player;
    Character character;

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

        if(collision.gameObject.TryGetComponent<Enermy>(out Enermy enermyComponent))
        {
            player = CharacterSelect.selectedCharater;
            if (player.name == "HeroGun")
            {
                character = new HeroGun(player);
                enermyComponent.TakeDamage(character.damage);
                Debug.Log(character.damage);
            }
            if (player.name == "HeroSword")
            {
                character = new HeroSword(player);
                enermyComponent.TakeDamage(character.damage);
                Debug.Log(character.damage);
            }
            
        }

        Destroy(gameObject);
    }
}
