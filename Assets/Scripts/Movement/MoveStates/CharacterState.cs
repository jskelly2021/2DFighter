using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterState : MonoBehaviour
{
    protected Rigidbody2D body;

    protected bool isFacingRight;
    protected bool isGrounded;

    protected float walkDirection = 0f;
    protected bool isJumping = false;
    protected bool isCrouching = false;

    protected CharacterBase character;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
        body = character.body;

        isFacingRight = character.IsFacingRight();
        isGrounded = character.IsGrounded();
    }

    void Update()
    {
        IsGrounded();
        CheckFlipCharacter();
        walkDirection = character.GetDirection();
        isJumping = character.GetJumping();
        isCrouching = character.GetCrouching();
    }

    public virtual void MoveHorizontal() { }
    public virtual void Crouch() { }
    public virtual void Jump() { }

    public virtual void CheckFlipCharacter()
    {
        isFacingRight = character.IsFacingRight();

        if (body.velocity.x < 0 && isFacingRight)
        {
            isFacingRight = false;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
        else if (body.velocity.x > 0 && !isFacingRight)
        {
            isFacingRight = true;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
        character.SetFacingRight(isFacingRight);
    }

    public virtual void IsGrounded()
    {
        isGrounded = character.IsGrounded();

        if (character.groundCheck.IsTouchingLayers(character.groundLayerMask))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        character.SetGrounded(isGrounded);
    }
}

public enum characterState
{
    idle,
    run,
    jump,
    crouch,
    hurt,
    dead
}