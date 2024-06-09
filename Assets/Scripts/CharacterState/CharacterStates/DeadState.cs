
using UnityEngine;

public class DeadState : BaseCharacterState
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
