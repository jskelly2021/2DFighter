using UnityEngine;

public class PlayerInput : InputComponent
{
    private CharacterBase character;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
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
        character.SetDirection(xInput);
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
}
