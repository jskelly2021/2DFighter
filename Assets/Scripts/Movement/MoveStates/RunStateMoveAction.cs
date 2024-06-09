
using UnityEngine;

public class RunStateMoveAction : CharacterState
{
    public override void MoveHorizontal()
    {
        body.velocity = new Vector2(character.GetWalkDirection() * character.speed, body.velocity.y);

        if (character.GetWalkDirection() == 0)
            character.SetCharacterState(characterState.idle);
    }

    public override void Jump()
    {
        if (character.IsJumping() && character.IsGrounded())
        {
            body.velocity = new Vector2(body.velocity.x, character.jumpForce);
            character.SetCharacterState(characterState.jump);
        }
    }
}
