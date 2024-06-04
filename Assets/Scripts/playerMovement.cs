
using UnityEngine;

public class PlayerMovement : MoveComponent
{
    [SerializeField] private Rigidbody2D body;

    public override void Move(CharacterBase character)
    {
            
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

}
