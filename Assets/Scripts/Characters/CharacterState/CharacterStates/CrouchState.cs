
using UnityEngine;

public class CrouchState : CharacterState
{
    protected override void MoveHorizontal(float direction)
    {
        body.velocity = new Vector2(0, body.velocity.y);
    }

    protected override void Crouch()
    {
        character.CurrentState = CharacterStates.Idle;
    }

    protected override void Attack()
    {
        character.CurrentState = CharacterStates.LowAttack;
    }
}
