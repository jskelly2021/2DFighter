
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

    private void OnEnable()
    {
        character.onJump += Jump;
    }

    private void OnDisable()
    {
        character.onJump -= Jump;
    }

    private void Update()
    {
        IsGrounded();
        CheckFlipCharacter();
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

        if (character.IsGrounded)
            character.extraJumpsLeft = character.ExtraJumps;
    }

    protected virtual void MoveHorizontal() { }
    protected virtual void Crouch() { }
    protected virtual void Jump() { }
    protected virtual void Dead() 
    {
        if (character.IsDead)
        {
            character.SetCharacterState(CharacterState.Dead);
        }
    }
    protected virtual void Attack() { }
    protected virtual void Block() { }
}


