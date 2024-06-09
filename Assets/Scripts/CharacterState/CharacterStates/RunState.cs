
using UnityEngine;

public class RunStateMoveAction : CharacterState
{
    public override void MoveHorizontal()
    {
        body.velocity = new Vector2(character.direction * character.speed, body.velocity.y);

        if (character.direction == 0)
            character.SetCharacterState(characterState.idle);
    }

    public override void Jump()
    {
        if (character.isJumping && character.isGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, character.jumpForce);
            character.SetCharacterState(characterState.jump);
        }
    }
}
