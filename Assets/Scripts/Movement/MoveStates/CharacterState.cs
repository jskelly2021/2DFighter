
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
        if (body.velocity.x < 0 && character.IsFacingRight())
        {
            character.SetFacingRight(false);
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
        character.SetGrounded(character.groundCheck.IsTouchingLayers(character.groundLayerMask));
    }

    public virtual void MoveHorizontal() { }
    public virtual void Crouch() { }
    public virtual void Jump() { }
    public virtual void Hurt() { }
    public virtual void Dead() 
    {
        if (character.IsDead())
        {
            character.SetCharacterState(characterState.dead);
        }
    }


    public virtual void Attack() 
    {
        if (character.IsAttacking())
        {
            character.SetCharacterState(characterState.attack);
        }
    }
}


