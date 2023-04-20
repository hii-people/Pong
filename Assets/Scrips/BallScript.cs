using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private new Rigidbody2D rigidbody2D;
    public float speed = 200f;

    private void Awake()
    {
        //print("BallScript void Awake");
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        ResetPosition();

        AddStartingForce();

    }

    public void AddStartingForce()
    {
        float x_direction = Random.value < 0.5f ? -1f : 1f;
        float y_direction = Random.value < 0.5f ? Random.Range(-1f,-0.5f) : Random.Range(0.5f, 1f);

        // The direction and the speed of the ball
        rigidbody2D.AddForce(new Vector2(x_direction, y_direction) * speed);
    }

    public void AddForce(Vector2 force)
    {
        rigidbody2D.AddForce(force);
    }

    public void ResetPosition()
    {
        rigidbody2D.position = Vector2.zero;
        rigidbody2D.velocity = Vector2.zero;
    }
}
