
using UnityEngine;

public class CrouchStateMoveAction : CharacterState
{
    public override void MoveHorizontal()
    {
        body.velocity = new Vector2(0, body.velocity.y);
    }

    public override void Crouch()
    {
        if (character.IsCrouching())
        {
            character.SetCharacterState(characterState.crouch);
        }
        else
        {
            character.SetCharacterState(characterState.idle);
        }
    }
}
