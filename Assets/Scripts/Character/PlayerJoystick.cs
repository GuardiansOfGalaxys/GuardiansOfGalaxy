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

    public static bool PointerDown = false;


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
        //rotation
        float hAxis = move.x;
        float vAxis = move.y;
        float zAxis = Mathf.Atan2(hAxis,vAxis) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0f, 0f, -zAxis);
    }

    private void FixedUpdate()
    {
        if(PointerDown)
        {
            rb.velocity = Vector3.zero;
        }
        else
        {
            rb.MovePosition(rb.position + move * player.speed * Time.fixedDeltaTime);
        }
        
    }
}
