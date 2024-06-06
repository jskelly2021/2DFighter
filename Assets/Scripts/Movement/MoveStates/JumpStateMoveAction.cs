
using UnityEngine;

public class JumpStateMoveAction : CharacterState
{
    private void FixedUpdate()
    {
        MoveHorizontal();
    }

    public override void MoveHorizontal()
    {
        body.velocity = new Vector2(walkDirection * character.speed, body.velocity.y);
    }

    public override void IsGrounded()
    {
        if (character.groundCheck.IsTouchingLayers(character.groundLayerMask))
        {
            isGrounded = true;
            character.SetCharacterState(characterState.idle);
        }
        else
        {
            isGrounded = false;
        }
    }

}
