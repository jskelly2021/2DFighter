
using UnityEngine;

public class DeadStateMoveAction : CharacterState
{

    // Only for testing
    public override void Jump()
    {
        if (character.isJumping)
        {
            character.SetCharacterState(characterState.jump);
        }
    }
}
