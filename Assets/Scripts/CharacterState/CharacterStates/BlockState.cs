
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BlockState : CharacterState
{
    protected override void MoveHorizontal(float direction)
    {
        body.velocity = new Vector2(direction * (character.Speed / 2), body.velocity.y);
    }

    protected override void Block()
    {
        character.CurrentState = CharacterStates.Idle;
    }
}
