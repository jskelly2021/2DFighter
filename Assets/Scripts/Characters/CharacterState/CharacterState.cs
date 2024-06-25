
using UnityEngine;

public abstract class CharacterState : MonoBehaviour
{
    protected CharacterBase character;
    protected CharacterController controller;
    protected Rigidbody2D body;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
        controller = GetComponent<CharacterController>();
        body = character.body;
    }

    private void OnEnable()
    {
        controller.onJump += Jump;
        controller.onAttack += Attack;
        controller.onBlock += Block;
    }

    private void OnDisable()
    {
        controller.onJump -= Jump;
        controller.onAttack -= Attack;
        controller.onBlock -= Block;
    }

    private void Update()
    {
        IsGrounded();
        FlipCharacter();
    }

    private void FixedUpdate()
    {
        MoveHorizontal(character.CurrentVelocity);
    }

    protected virtual void IsGrounded() 
    {
        character.IsGrounded = character.groundCheck.IsTouchingLayers(character.groundLayerMask);
        character.ExtraJumpsLeft = character.NumExtraJumps;
    }

    protected void FlipCharacter()
    {
        if (body.velocity.x < 0)
            character.LookDirection = -1;

        else if (body.velocity.x > 0)
            character.LookDirection = 1;

        transform.localScale = new Vector2(character.LookDirection, transform.localScale.y);
    }

    protected virtual void MoveHorizontal(float direction) { }
    protected virtual void Crouch() { }
    protected virtual void Jump() { }
    protected virtual void Attack() { }
    protected virtual void Block() { }
}
