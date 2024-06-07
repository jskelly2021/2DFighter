
using UnityEngine;

public class JumpStateMoveAction : CharacterState
{
    private void FixedUpdate()
    {
        MoveHorizontal();
    }

    public override void MoveHorizontal()
    {
        body.velocity = new Vector2(character.GetWalkDirection() * character.speed, body.velocity.y);
    }

    protected override void IsGrounded()
    {
        if (character.groundCheck.IsTouchingLayers(character.groundLayerMask))
        {
            character.SetGrounded(true);
            character.SetCharacterState(characterState.idle);
        }
        else
        {
            character.SetGrounded(false);
        }
    }

}
