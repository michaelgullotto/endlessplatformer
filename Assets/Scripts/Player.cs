using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public Animator animator;

    public float speed = 10f;
    float movement = 0f;
    Rigidbody2D rb;

    public Vector3 startPosition;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();

        startPosition = transform.position;
    }

   
    void Update()
    {
       movement = Input.GetAxis("Horizontal") * speed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;

    }
}
