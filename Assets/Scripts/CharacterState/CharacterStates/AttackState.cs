
using UnityEngine;

public class AttackStateMoveAction : CharacterState
{
    public override void MoveHorizontal()
    {
        body.velocity = new Vector2(0, body.velocity.y);
    }
}
