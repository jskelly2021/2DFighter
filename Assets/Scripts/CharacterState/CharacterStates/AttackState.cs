
using UnityEngine;

public class AttackState : CharacterState
{
    protected override void MoveHorizontal(float direction)
    {
        body.velocity = new Vector2(direction * character.Speed, body.velocity.y);
    }

    protected override void Attack()
    {
        character.CurrentState = CharacterStates.Idle;
    }
}
