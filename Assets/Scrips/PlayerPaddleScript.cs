using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleScript : PaddleScript
{
    private Vector2 direction;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            direction = Vector2.up;
            //print("UP vector");
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            direction = Vector2.down;
            //print("Down vector");
        }
        else
        {
            direction = Vector2.zero;
            //print("No vector");
        }

    }

    //Player paddle Movement
    private void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
        {
            rigidbody2D.AddForce(direction * speed);
        }
    }
}
