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

    [SerializeField] private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal Movement
        HandleHorizontalMove();

        // Jump
        HandleJump();
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
        
        // Animation Check
        if (xInput != 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }


    // Handle Jump
    void HandleJump()
    {
        // Is player grounded
        if (groundCheck.IsTouchingLayers(groundLayerMask))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        animator.SetBool("isGrounded", isGrounded);

        // Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, jumpForce);
        }

        if(body.velocity.y > 0)
        {
            animator.SetBool("isJumping", true);
        }
        else
        {
            animator.SetBool("isJumping", false);
        }
    }

}
