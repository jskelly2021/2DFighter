
using UnityEngine;

public class JumpState : BaseCharacterState
{
    protected void FixedUpdate()
    {
        MoveHorizontal();
        Crouch();
        Jump();
        Attack();
    }

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

    protected override void Attack()
    {
        if (character.IsAttacking)
            character.SetCharacterState(CharacterState.HighAttack);
    }

}
