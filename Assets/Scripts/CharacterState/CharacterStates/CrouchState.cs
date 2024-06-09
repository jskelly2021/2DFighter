
using UnityEngine;

public class CrouchState : BaseCharacterState
{
    protected override void MoveHorizontal()
    {
        body.velocity = new Vector2(0, body.velocity.y);
    }

    protected override void Crouch()
    {
        if (character.IsCrouching)
        {
            character.SetCharacterState(CharacterState.Crouch);
        }
        else
        {
            character.SetCharacterState(CharacterState.Idle);
        }
    }

    protected override void Attack()
    {
        if (character.IsAttacking)
            character.SetCharacterState(CharacterState.LowAttack);
    }
}
