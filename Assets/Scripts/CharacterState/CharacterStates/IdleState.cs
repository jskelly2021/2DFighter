
using UnityEngine;

public class IdleState : CharacterState
{
    protected override void MoveHorizontal(float direction)
    {
        body.velocity = new Vector2(direction * characterStats.speed, body.velocity.y);

        if (direction != 0)
        {
            stateMachine.ChangeCharacterState(CharacterStates.Run);
        }
    }

    protected override void Crouch()
    {
        stateMachine.ChangeCharacterState(CharacterStates.Crouch);
    }

    protected override void Jump()
    {
        if (characterStats.IsGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, characterStats.jumpForce);
            stateMachine.ChangeCharacterState(CharacterStates.Jump);
        }
    }

    protected override void Attack()
    {
        stateMachine.ChangeCharacterState(CharacterStates.NuetralAttack);
    }

    protected override void Block()
    {
        stateMachine.ChangeCharacterState(CharacterStates.Block);
    }

    protected override void Dead() {}
}
