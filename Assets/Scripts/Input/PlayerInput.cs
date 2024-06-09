using UnityEngine;

public class PlayerInput : InputComponent
{
    protected override void HandleInput()
    {
        CheckMoveHorizontal();
        CheckJump();
        CheckCrouch();
        CheckHurt();
        CheckDead();
        CheckAttack();
    }

    private void CheckMoveHorizontal()
    {
        float xInput = Input.GetAxis("Horizontal");   
        character.Direction = xInput;
    }

    private void CheckJump()
    {
        bool isJumping = (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W));
        character.IsJumping = isJumping;
    }

    private void CheckCrouch()
    {
        bool isCrouching = Input.GetKey(KeyCode.S);
        character.IsCrouching = isCrouching;
    }

    private void CheckHurt()
    {
        bool isHurt = Input.GetKey(KeyCode.J);
        character.IsHurt = isHurt;  
    }

    private void CheckDead()
    {
        bool isDead = Input.GetKey(KeyCode.K);
        character.IsDead = isDead;
    }

    private void CheckAttack()
    {
        bool isAttacking = Input.GetKey(KeyCode.F);
        character.IsAttacking = isAttacking;
    }

}
