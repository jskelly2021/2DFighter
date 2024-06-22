
using UnityEngine;

public class IdleState : CharacterState
{
    protected override void MoveHorizontal(float direction)
    {
        body.velocity = new Vector2(character.Direction * character.Speed, body.velocity.y);

        if (character.Direction != 0)
        {
            character.SetCharacterState(CharacterState.Run);
        }
    }

    protected override void Crouch()
    {
        if (character.IsCrouching)
        {
            character.SetCharacterState(CharacterState.Crouch);
        }
    }

    protected override void Jump()
    {
        if (character.IsJumping && character.IsGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, character.JumpForce);
            character.SetCharacterState(CharacterState.Jump);
        }
    }

    protected override void Attack()
    {
        if (character.IsAttacking)
            character.SetCharacterState(CharacterState.NuetralAttack);
    }

    protected override void Block()
    {
        if (character.IsBlocking)
            character.SetCharacterState(CharacterState.Block);
    }

    protected override void Dead() { }
}
