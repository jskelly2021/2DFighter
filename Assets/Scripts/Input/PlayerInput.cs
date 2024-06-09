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
        character.SetWalkDirection(xInput);
    }

    private void CheckJump()
    {
        bool isJumping = (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W));
        character.SetJumping(isJumping);
    }

    private void CheckCrouch()
    {
        bool isCrouching = Input.GetKey(KeyCode.S);
        character.SetCrouching(isCrouching);
    }

    private void CheckHurt()
    {
        bool isHurt = Input.GetKey(KeyCode.J);
        character.SetHurt(isHurt);
    }

    private void CheckDead()
    {
        bool isDead = Input.GetKey(KeyCode.K);
        character.SetDead(isDead);
    }

    private void CheckAttack()
    {
        bool isAttacking = Input.GetKey(KeyCode.F);
        character.SetAttack(isAttacking);
    }

}
