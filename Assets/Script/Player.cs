using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jump;

    private float Move;

    public Rigidbody2D rb;

    public bool isJumping;

    //public Animator animator;
    private void Start()
    {
            
    }

    private void Update()
    {
        Move = Input.GetAxis("Horizontal");

        //animator.SetFloat("Speed", Mathf.Abs(Move));
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }

        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor")) 
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
    }
}

