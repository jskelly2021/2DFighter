
using UnityEngine;

public class PlayerMovement : MoveComponent
{
    [SerializeField] private Rigidbody2D body;
    [SerializeField] private LayerMask groundLayerMask;
    [SerializeField] private BoxCollider2D groundCheck;

    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    private CharacterBase character;
    private bool isFacingRight = true;
    private bool isGrounded = true;


    public override void GetMovement(CharacterBase character)
    {
        this.character = character;
    }

    private void FixedUpdate()
    {
        MoveHorizontal();
        Crouch();
        Jump();
    }

    // Move Horizontally
    public void MoveHorizontal()
    {
        body.velocity = new Vector2(input * speed, body.velocity.y);
        if (input != 0)
        {
            Flip(input);
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }

    // Crouching
    public void Crouch()
    {
        
    }

    // Jump
    public void Jump()
    {
        if (isGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, jumpForce);
            animator.SetTrigger("jump");
        }
    }

    // Flip player
    public void Flip(float input)
    {
        if (input < 0 && isFacingRight)
        {
            isFacingRight = false;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
        if (input > 0 && !isFacingRight)
        {
            isFacingRight = true;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }

    // Is player grounded
    public void IsGrounded()
    {
        if (groundCheck.IsTouchingLayers(groundLayerMask))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        animator.SetBool("isGrounded", isGrounded);
    }
}
