
using UnityEngine;

public abstract class CharacterState : MonoBehaviour
{
    protected Rigidbody2D body;
    protected CharacterBase character;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
        body = character.body;
    }

    void Update()
    {
        IsGrounded();
        CheckFlipCharacter();
    }

    protected void CheckFlipCharacter()
    {
        if (body.velocity.x < 0 && character.IsFacingRight())
        {
            character.SetFacingRight(true);
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
        else if (body.velocity.x > 0 && !character.IsFacingRight())
        {
            character.SetFacingRight(true);
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }

    protected virtual void IsGrounded()
    {
        if (character.groundCheck.IsTouchingLayers(character.groundLayerMask))
        {
            character.SetGrounded(true);
        }
        else
        {
            character.SetGrounded(false);
        }
    }

    public virtual void MoveHorizontal() { }
    public virtual void Crouch() { }
    public virtual void Jump() { }
}

public enum characterState
{
    start,
    idle,
    run,
    jump,
    crouch,
    hurt,
    dead
}

