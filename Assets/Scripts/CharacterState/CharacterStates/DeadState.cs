
using UnityEngine;

public class DeadState : BaseCharacterState
{

    // Only for testing
    protected override void Jump()
    {
        if (character.IsJumping)
        {
            character.SetCharacterState(CharacterState.Jump);
        }
    }
}
