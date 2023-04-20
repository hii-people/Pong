using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddleScript : PaddleScript
{
    //[SerializeField] private Rigidbody2D ballRigidbody2D;

    //private void Awake()
    //{
    //    print("ComputerPaddleScript void Awake");

    //    //rigidbody2D = GetComponent<Rigidbody2D>();

    //    //ballGameObject = GameObject.FindGameObjectWithTag("Ball");
    //    ballRigidbody2D = GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody2D>();
    //}



    private void FixedUpdate()
    {
        if(ballRigidbody2D.velocity.x > 0f)
        {
            if(ballRigidbody2D.position.y > transform.position.y)
            {
                rigidbody2D.AddForce(Vector2.up * speed);
            }
            else if (ballRigidbody2D.position.y < transform.position.y)
            {
                rigidbody2D.AddForce(Vector2.down * speed);
            }
            else
            {
                if (transform.position.y > 0f)
                {
                    rigidbody2D.AddForce(Vector2.down * speed);
                }
                else if (transform.position.y < 0f)
                {
                    rigidbody2D.AddForce(Vector2.up * speed);
                }

            }
        }
    }
}
