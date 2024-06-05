
using UnityEngine;

public abstract class MoveComponent : MonoBehaviour
{
    protected Rigidbody2D body;

    protected bool isFacingRight = true;
    protected bool isGrounded = true;

    protected CharacterBase character;
    
    public void InitMovement(CharacterBase character)
    {
        this.character = character;
        this.body = character.body;
    }

    public virtual void MoveHorizontal() {}
    public virtual void Crouch() {}
    public virtual void Jump() {}

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

    public MoveComponent ChangeMoveState()
    {
        switch (character.GetCharacterState())
        {
            case characterState.idle:
                return new IdleStateMoveAction();
            case characterState.jump: 
                return new JumpStateMoveAction();
            default:
                return this;
        }
    }
}
