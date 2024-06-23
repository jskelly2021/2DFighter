
using UnityEngine;

public class RunState : CharacterState
{
    protected override void MoveHorizontal(float direction)
    {
        body.velocity = new Vector2(direction * character.speed, body.velocity.y);

        if (direction == 0)
            stateMachine.ChangeCharacterState(CharacterStates.Idle);
    }

    protected override void Jump()
    {
        if (character.IsGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, character.jumpForce);
            stateMachine.ChangeCharacterState(CharacterStates.Jump);
        }
    }

    protected override void Attack()
    {
        if (body.velocity.x > 0)
            stateMachine.ChangeCharacterState(CharacterStates.FrontAttack);
        else
            stateMachine.ChangeCharacterState(CharacterStates.BackAttack);
    }

    protected override void Block() {}
    protected override void Crouch() {}

}
