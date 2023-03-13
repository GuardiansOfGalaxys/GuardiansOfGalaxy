using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Bullet : MonoBehaviour
{
    public float speedAttack;
    public Rigidbody2D rb;
    GameObject player;
    Character character;

    //// Start is called before the first frame update
    void start()
    {
        player = CharacterSelect.selectedCharater;
        if (player.name == "HeroGun")
        {
            character = new HeroGun(player);
            speedAttack = character.speedAttack;
        }
        rb.velocity = transform.right * speedAttack;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enermy>(out Enermy enermyComponent))
        {
            if (collision.name == "EnermyLv1(Clone)" || collision.name == "EnermyLv2(Clone)" || collision.name == "EnermyLv3(Clone)")
            {

                player = CharacterSelect.selectedCharater;
                if (player.name == "HeroGun")
                {
                    character = new HeroGun(player);
                    enermyComponent.TakeDamage(character.damage);
                    Destroy(gameObject);
                }

            }

        }

    }
}
