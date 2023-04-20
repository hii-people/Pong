using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    [SerializeField] protected new Rigidbody2D rigidbody2D;
    [SerializeField] protected Rigidbody2D ballRigidbody2D;

    public float speed = 10f;

    private void Awake()
    {
        print("PaddleScript void Awake");
        rigidbody2D = GetComponent<Rigidbody2D>();

        //rigidbody2D = GetComponent<Rigidbody2D>();

        //ballGameObject = GameObject.FindGameObjectWithTag("Ball");
        ballRigidbody2D = GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        rigidbody2D.position = new Vector2(rigidbody2D.position.x, 0f);
        rigidbody2D.velocity = Vector2.zero;
    }
}
