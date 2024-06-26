
using UnityEngine;

public class JumpState : CharacterState
{
    protected override void MoveHorizontal(float direction)
    {
        body.velocity = new Vector2(direction * character.Speed, body.velocity.y);
    }

    protected override void Jump()
    {
        if (character.ExtraJumpsLeft <= 0)
            return;

        character.ExtraJumpsLeft -= 1;
        body.velocity = new Vector2(body.velocity.x, character.JumpForce);
        character.CurrentState = CharacterStates.Jump;
    }

    protected override void Attack()
    {
        character.CurrentState = CharacterStates.HighAttack;
    }

    protected override void IsGrounded()
    {
        if (character.IsGrounded && body.velocity.y == 0)
            character.CurrentState = CharacterStates.Idle;

    }
}
