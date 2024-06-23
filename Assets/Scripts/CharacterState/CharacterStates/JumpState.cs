
using UnityEngine;

public class JumpState : CharacterState
{
    protected override void MoveHorizontal(float direction)
    {
        body.velocity = new Vector2(direction * character.speed, body.velocity.y);
    }

    protected override void IsGrounded()
    {
        if (character.groundCheck.IsTouchingLayers(character.groundLayerMask))
        {
            character.IsGrounded = true;
            character.SetCharacterState(CharacterState.Idle);
        }
        else
        {
            character.IsGrounded = false;
        }
    }

    protected override void Jump()
    {
        if (stats.extraJumps <= 0)
            return;

        stats.extraJumps -= 1;
        body.velocity = new Vector2(body.velocity.x, stats.jumpForce);
        stateMachine.ChangeCharacterState(CharacterStates.Jump);
    }

    protected override void Attack()
    {
            stateMachine.ChangeCharacterState(CharacterStates.HighAttack);
    }

    protected override void Block() {}
    protected override void Crouch() {}
}
