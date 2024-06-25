
using UnityEngine;

public class IdleState : CharacterState
{
    protected override void MoveHorizontal(float direction)
    {
        body.velocity = new Vector2(direction * character.Speed, body.velocity.y);

        if (direction != 0)
        {
            character.CurrentState = CharacterStates.Run;
        }
    }

    protected override void Crouch()
    {
        character.CurrentState = CharacterStates.Crouch;
    }

    protected override void Jump()
    {
        if (character.IsGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, character.JumpForce);
            character.CurrentState = CharacterStates.Jump;
        }
    }

    protected override void Attack()
    {
        character.CurrentState = CharacterStates.NuetralAttack;
    }

    protected override void Block()
    {
        character.CurrentState = CharacterStates.Block;
    }
}
