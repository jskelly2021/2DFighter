
using UnityEngine;

public class DeadState : BaseCharacterState
{
    protected void FixedUpdate()
    {
        Jump();
    }

    // Only for testing
    protected override void Jump()
    {
        if (character.IsJumping)
        {
            character.SetCharacterState(CharacterState.Jump);
        }
    }
}
