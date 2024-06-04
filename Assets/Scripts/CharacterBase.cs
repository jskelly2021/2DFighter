using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class CharacterBase : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayerMask;
    [SerializeField] private Rigidbody2D body;
    [SerializeField] private BoxCollider2D groundCheck;
    [SerializeField] private Animator animator;

    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    private bool isFacingRight = true;
    private bool isGrounded = true;

    [SerializeField] private InputComponent input;
    [SerializeField] private MoveComponent movement;

    private void Update()
    {
        input.GetInput(this);
        movement.Move(this);
        IsGrounded();
    }

    // Move Horizontally
    public void MoveHorizontal(float input)
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
    public void Crouch(bool isCrouching)
    {
        animator.SetBool("isCrouching", isCrouching);
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
