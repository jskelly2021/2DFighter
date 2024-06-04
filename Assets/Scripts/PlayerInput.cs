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
        character.MoveHorizontal(xInput);
    }

    void CheckJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            character.Jump();
        }
    }

    void CheckCrouch()
    {
        bool isCrouching = Input.GetKey(KeyCode.S);
        character.Crouch(isCrouching);
    }
}
