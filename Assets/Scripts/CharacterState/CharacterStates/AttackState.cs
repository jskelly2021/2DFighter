
using UnityEngine;

public class AttackState : BaseCharacterState
{
    protected void FixedUpdate()
    {
        MoveHorizontal();    
    }

    protected override void MoveHorizontal()
    {
        body.velocity = new Vector2(character.Direction * character.Speed, body.velocity.y);
    }
}
