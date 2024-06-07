
using UnityEngine;

public class IdleStateMoveAction : CharacterState
{
    private void FixedUpdate()
    {
        MoveHorizontal();
        Crouch();
        Jump();
        Hurt();
    }

    public override void MoveHorizontal()
    {
        body.velocity = new Vector2(character.GetWalkDirection() * character.speed, body.velocity.y);

        if (character.GetWalkDirection() != 0)
        {
            character.SetCharacterState(characterState.run);
        }
    }

    public override void Crouch()
    {
        if (character.IsCrouching())
        {
            character.SetCharacterState(characterState.crouch);
        }
    }

    public override void Jump()
    {
        if (character.IsJumping() && character.IsGrounded())
        {
            body.velocity = new Vector2(body.velocity.x, character.jumpForce);
            character.SetCharacterState(characterState.jump);
        }
    }

    public override void Hurt()
    {
        if (character.IsHurt())
        {
            character.SetCharacterState(characterState.hurt);
        }
    }
}
