using UnityEngine;

public class PlayerInput : InputComponent
{
    public void Update()
    {
        CheckMoveHorizontal();
        CheckJump();
        CheckCrouch();
        CheckHurt();
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
}
