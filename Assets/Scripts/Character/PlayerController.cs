using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Character player;
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
}