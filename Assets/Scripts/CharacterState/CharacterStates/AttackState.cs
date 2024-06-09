
using UnityEngine;

public class AttackState : BaseCharacterState
{
    protected override void MoveHorizontal()
    {
        body.velocity = new Vector2(0, body.velocity.y);
    }
}
