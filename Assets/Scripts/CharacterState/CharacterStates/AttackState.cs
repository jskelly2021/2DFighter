
using UnityEngine;

public class AttackState : BaseCharacterState
{
    public override void MoveHorizontal()
    {
        body.velocity = new Vector2(0, body.velocity.y);
    }
}
