using UnityEngine;

public class PlayerInput : InputComponent
{
    private CharacterBase character;

    public override void GetInput(CharacterBase character)
    {
        this.character = character;
    }

    public void Update()
    {
        CheckMoveHorizontal();
        CheckJump();
        CheckCrouch();
    }

    void CheckMoveHorizontal()
    {
        float xInput = Input.GetAxis("Horizontal");   
        character.SetHorizontalVelocity(xInput);
    }

    void CheckJump()
    {
        bool isJumping = (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W));
        character.SetJumping(isJumping);
    }

    void CheckCrouch()
    {
        bool isCrouching = Input.GetKey(KeyCode.S);
        character.SetCrouching(isCrouching);
    }
}

public enum playerInput
{
    run,
    jump,
    crouch
}
