using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterState : MonoBehaviour
{
    protected Rigidbody2D body;

    protected bool isFacingRight = true;
    protected bool isGrounded = true;

    protected CharacterBase character;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
        body = character.body;
    }

    public virtual void MoveHorizontal() { }
    public virtual void Crouch() { }
    public virtual void Jump() { }

    public virtual void FlipCharacter(float direction)
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

    public virtual void IsGrounded()
    {
        if (character.groundCheck.IsTouchingLayers(character.groundLayerMask))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
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