using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CrouchStateMoveAction : CharacterState
{
    private void FixedUpdate()
    {
        Crouch();
    }

    public override void Crouch()
    {
        if (isCrouching)
        {
            character.SetCharacterState(characterState.crouch);
        }
        else
        {
            character.SetCharacterState(characterState.idle);
        }
    }

}
