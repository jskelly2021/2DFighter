
using UnityEngine;

public class IdleState : BaseCharacterState
{
    protected override void MoveHorizontal()
    {
        body.velocity = new Vector2(character.Direction * character.Speed, body.velocity.y);

        if (character.Direction != 0)
        {
            character.SetCharacterState(characterState.run);
        }
    }

    protected override void Crouch()
    {
        if (character.IsCrouching)
        {
            character.SetCharacterState(characterState.crouch);
        }
    }

    protected override void Jump()
    {
        if (character.IsJumping && character.IsGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, character.JumpForce);
            character.SetCharacterState(characterState.jump);
        }
    }

    protected override void Hurt()
    {
        if (character.IsHurt)
        {
            character.SetCharacterState(characterState.hurt);
        }
    }
}
