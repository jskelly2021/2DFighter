
using UnityEngine;

public class RunStateMoveAction : CharacterState
{
    private void FixedUpdate()
    {
        MoveHorizontal();
        Jump();
    }

    public override void MoveHorizontal()
    {
        body.velocity = new Vector2(walkDirection * character.speed, body.velocity.y);

        if (walkDirection == 0)
            character.SetCharacterState(characterState.idle);
    }

    public override void Jump()
    {
        if (isJumping && isGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, character.jumpForce);
            character.SetCharacterState(characterState.jump);
        }
    }
}
