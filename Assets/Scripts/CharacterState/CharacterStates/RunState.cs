
using UnityEngine;

public class RunState : BaseCharacterState
{
    protected override void MoveHorizontal()
    {
        body.velocity = new Vector2(character.Direction * character.Speed, body.velocity.y);

        if (character.Direction == 0)
            character.SetCharacterState(characterState.idle);
    }

    protected override void Jump()
    {
        if (character.IsJumping && character.IsGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, character.JumpForce);
            character.SetCharacterState(characterState.jump);
        }
    }
}
