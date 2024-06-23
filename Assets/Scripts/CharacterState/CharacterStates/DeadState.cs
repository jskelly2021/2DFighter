
using UnityEngine;

public class DeadState : CharacterState
{
    // Only for testing
    protected override void Jump()
    {
        character.CurrentState = CharacterStates.Jump;
    }
}
