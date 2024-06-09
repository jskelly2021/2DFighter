
using UnityEngine;

public class AttackState : BaseCharacterState
{
    protected override void MoveHorizontal()
    {
        body.velocity = new Vector2(character.Direction * character.Speed, body.velocity.y);
    }
}
