using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayerMask;

    public Rigidbody2D body;

    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    [SerializeField] private BoxCollider2D groundCheck;
    private bool isGrounded = true;

    private bool isFacingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal Movement
        HandleHorizontalMove();

        // Is player grounded
        if (groundCheck.IsTouchingLayers(groundLayerMask))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        // Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, jumpForce);
        }

    }


    // Hanle horizontal movement and flip player transform when necessary
    void HandleHorizontalMove()
    {
        float xInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(xInput * speed, body.velocity.y);

        // Flip player
        if (xInput < 0 && isFacingRight)
        {
            isFacingRight = false;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
        if (xInput > 0 && !isFacingRight)
        {
            isFacingRight = true;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }

}
