using UnityEngine;

public class PlayerInput : InputComponent
{
    public void Update()
    {
        CheckMoveHorizontal();
        CheckJump();
        CheckCrouch();
        CheckHurt();
        CheckDead();
        CheckAttack();
    }

    void CheckMoveHorizontal()
    {
        float xInput = Input.GetAxis("Horizontal");   
        character.SetWalkDirection(xInput);
    }

    void CheckJump()
    {
        bool isJumping = (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W));
        character.SetJumping(isJumping);
    }

    void CheckCrouch()
    {
        bool isCrouching = Input.GetKey(KeyCode.S);
        character.SetCrouching(isCrouching);
    }

    void CheckHurt()
    {
        bool isHurt = Input.GetKey(KeyCode.J);
        character.SetHurt(isHurt);
    }

    void CheckDead()
    {
        bool isDead = Input.GetKey(KeyCode.K);
        character.SetDead(isDead);
    }

    void CheckAttack()
    {
        bool isAttacking = Input.GetKey(KeyCode.F);
        character.SetAttack(isAttacking);
    }

}
