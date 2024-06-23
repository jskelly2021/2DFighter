
using UnityEngine;

public class RunState : CharacterState
{
    protected override void MoveHorizontal(float direction)
    {
        body.velocity = new Vector2(direction * character.Speed, body.velocity.y);

        if (direction == 0)
            character.CurrentState = CharacterStates.Idle;
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
        if (body.velocity.x > 0)
            character.CurrentState = CharacterStates.FrontAttack;
        else
            character.CurrentState = CharacterStates.BackAttack;
    }   

}
