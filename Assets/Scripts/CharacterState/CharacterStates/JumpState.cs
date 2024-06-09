
using UnityEngine;

public class JumpState : BaseCharacterState
{
    public override void MoveHorizontal()
    {
        body.velocity = new Vector2(character.direction * character.speed, body.velocity.y);
    }

    protected override void IsGrounded()
    {
        if (character.groundCheck.IsTouchingLayers(character.groundLayerMask))
        {
            character.isGrounded = true;
            character.SetCharacterState(characterState.idle);
        }
        else
        {
            character.isGrounded = false;
        }
    }

}
