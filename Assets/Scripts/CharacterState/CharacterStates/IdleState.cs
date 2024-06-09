
using UnityEngine;

public class IdleState : BaseCharacterState
{
    public override void MoveHorizontal()
    {
        body.velocity = new Vector2(character.direction * character.speed, body.velocity.y);

        if (character.direction != 0)
        {
            character.SetCharacterState(characterState.run);
        }
    }

    public override void Crouch()
    {
        if (character.isCrouching)
        {
            character.SetCharacterState(characterState.crouch);
        }
    }

    public override void Jump()
    {
        if (character.isJumping && character.isGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, character.jumpForce);
            character.SetCharacterState(characterState.jump);
        }
    }

    public override void Hurt()
    {
        if (character.isHurt)
        {
            character.SetCharacterState(characterState.hurt);
        }
    }
}
