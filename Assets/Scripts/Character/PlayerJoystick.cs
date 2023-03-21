using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerJoystick : MonoBehaviour
{
    Character player;
    public FixedJoystick Joystick;
    Rigidbody2D rb;
    Vector2 move;
    //public float moveSpeed;


    private void Start()
    {
        player = InitPlayer.player;
        rb = GetComponent<Rigidbody2D>();
        Joystick = GameObject.Find("Fixed Joystick").GetComponent<FixedJoystick>();
    }

    private void Update()
    {
        move.x = Joystick.Horizontal;
        move.y = Joystick.Vertical;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * player.speed * Time.fixedDeltaTime);
    }
}
