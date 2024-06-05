
using Unity.Mathematics;
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

    private float walkDirection = 0f;
    private bool isJumping = false;
    private bool isCrouching = false;

    public override void GetMovement(CharacterBase character)
    {
        this.character = character;
    }

    private void Update()
    {
        walkDirection = character.GetDirection();
        isJumping = character.GetJumping();
        isCrouching = character.GetCrouching();
    }

    private void FixedUpdate()
    {
        MoveHorizontal();
        Crouch();
        Jump();
    }

    public void MoveHorizontal()
    {
        body.velocity = new Vector2(walkDirection * speed, body.velocity.y);
        FlipPlayer(body.velocity.x);
    }

    public void Crouch()
    {
        if (isCrouching)
        {

        }
    }

    public void Jump()
    {
        if (isJumping)
        {
            body.velocity = new Vector2(body.velocity.x, jumpForce);
        }
    }

    public void FlipPlayer(float direction)
    {
        if (direction < 0 && isFacingRight)
        {
            isFacingRight = false;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
        if (direction > 0 && !isFacingRight)
        {
            isFacingRight = true;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }

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
    }

    public void Move()
    {
        
    }
}
