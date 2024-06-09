
using UnityEngine;

public class JumpState : BaseCharacterState
{
    protected override void MoveHorizontal()
    {
        body.velocity = new Vector2(character.Direction * character.Speed, body.velocity.y);
    }

    protected override void IsGrounded()
    {
        if (character.groundCheck.IsTouchingLayers(character.groundLayerMask))
        {
            character.IsGrounded = true;
            character.SetCharacterState(CharacterState.Idle);
        }
        else
        {
            character.IsGrounded = false;
        }
    }

}
