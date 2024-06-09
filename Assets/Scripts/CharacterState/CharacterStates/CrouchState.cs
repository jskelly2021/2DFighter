
using UnityEngine;

public class CrouchState : BaseCharacterState
{
    protected override void MoveHorizontal()
    {
        body.velocity = new Vector2(0, body.velocity.y);
    }

    protected override void Crouch()
    {
        if (character.IsCrouching)
        {
            character.SetCharacterState(characterState.crouch);
        }
        else
        {
            character.SetCharacterState(characterState.idle);
        }
    }
}
