using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 50.0f; // Adjust this to control the speed of movement.

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Input for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector2 movement = new Vector2(horizontalInput/2, verticalInput);

        // Normalize the movement vector to ensure constant speed in all directions
        movement.Normalize();

        // Apply movement
        rb.velocity = movement * moveSpeed;
    }
}

