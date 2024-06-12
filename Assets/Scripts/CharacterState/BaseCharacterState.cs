
using UnityEngine;

public abstract class BaseCharacterState : MonoBehaviour
{
    protected Rigidbody2D body;
    protected CharacterBase character;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
        body = character.body;
    }

    private void Update()
    {
        IsGrounded();
        CheckFlipCharacter();
    }

    private void FixedUpdate()
    {
        MoveHorizontal();
        Crouch();
        Jump();
        Hurt();
        Dead();
        Attack();
    }

    protected void CheckFlipCharacter()
    {
        if (character.Direction < 0 && character.IsFacingRight)
        {
            character.IsFacingRight = false;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
        else if (character.Direction > 0 && !character.IsFacingRight)
        {
            character.IsFacingRight = true;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
    protected virtual void IsGrounded()
    {
        character.IsGrounded = character.groundCheck.IsTouchingLayers(character.groundLayerMask);
    }

    protected virtual void MoveHorizontal() { }
    protected virtual void Crouch() { }
    protected virtual void Jump() { }
    protected virtual void Hurt() { }
    protected virtual void Dead() 
    {
        if (character.IsDead)
        {
            character.SetCharacterState(CharacterState.Dead);
        }
    }
    protected virtual void Attack() {}
}


