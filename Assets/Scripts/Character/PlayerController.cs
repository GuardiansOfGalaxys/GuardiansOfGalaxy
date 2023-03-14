using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Character player;
    // Start is called before the first frame update
    void Start()
    {
        player = InitPlayer.player;
    }

    // Update is called once per frame
    void Update()
    {
        player.Update();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            if (collision.name.Contains(Const.Item.Heal.name))
            {
                player.Heal();
            }
            if (collision.name.Contains(Const.Item.Ghost.name))
            {
                player.Ghost();
            }
            
            Destroy(collision.gameObject);
        }
    }
}