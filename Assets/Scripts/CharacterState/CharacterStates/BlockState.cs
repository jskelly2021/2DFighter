
using UnityEngine;

public class BlockState : BaseCharacterState
{
    protected void FixedUpdate()
    {
        MoveHorizontal();
        Block();
    }

    protected override void MoveHorizontal()
    {
        body.velocity = new Vector2(character.Direction * (character.Speed / 2), body.velocity.y);
    }

    protected override void Block()
    {
        if(!character.IsBlocking)
            character.SetCharacterState(CharacterState.Idle);
    }
}
