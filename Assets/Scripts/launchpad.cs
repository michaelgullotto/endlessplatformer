using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class launchpad : MonoBehaviour
{
   // public AudioSource gas;
    public float jumpForce = 50f;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.relativeVelocity.y <= 0f)
        {

            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;

                Player player = collision.collider.GetComponent<Player>();
                if (player != null)
                {
                  // gas.Play();
                    player.animator.SetTrigger("Jump");

                }
            }
        }
    }

}
