using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurfaceScript : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //BallScript ballScript = collision.gameObject.GetComponent<BallScript>();

        //if (ballScript != null)
        //{
        //    Vector2 normal = collision.GetContact(0).normal;
        //    ballScript.AddForce(-normal * this.bounceStrength);
        //}

        if (collision.gameObject.TryGetComponent(out BallScript ballScript))
        {
            Vector2 normal = collision.GetContact(0).normal;
            ballScript.AddForce(-normal * bounceStrength);
        }

    }
}
