
using UnityEngine;

public class CrouchState : BaseCharacterState
{
    public override void MoveHorizontal()
    {
        body.velocity = new Vector2(0, body.velocity.y);
    }

    public override void Crouch()
    {
        if (character.isCrouching)
        {
            character.SetCharacterState(characterState.crouch);
        }
        else
        {
            character.SetCharacterState(characterState.idle);
        }
    }
}
