
using UnityEngine;

public class RunStateMoveAction : CharacterState
{
    void Update()
    {
        IsGrounded();
        CheckFlipCharacter();
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

    public override void MoveHorizontal()
    {
        body.velocity = new Vector2(walkDirection * character.speed, body.velocity.y);

        if (walkDirection == 0)
            character.SetCharacterState(characterState.idle);
    }

    public override void Crouch()
    {
        if (isCrouching)
        {
            character.SetCharacterState(characterState.crouch);
        }
    }

    public override void Jump()
    {
        if (isJumping && isGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, character.jumpForce);
            character.SetCharacterState(characterState.jump);
        }
    }
}
