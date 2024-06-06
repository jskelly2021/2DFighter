
using UnityEngine;

public class IdleStateMoveAction : CharacterState
{
    private void FixedUpdate()
    {
        MoveHorizontal();
        Crouch();
        Jump();
    }

    public override void MoveHorizontal()
    {
        body.velocity = new Vector2(walkDirection * character.speed, body.velocity.y);

        if (walkDirection != 0)
            character.SetCharacterState(characterState.run);
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
