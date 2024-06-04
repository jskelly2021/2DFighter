using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : InputComponent
{
    public override void GetInput(CharacterBase character)
    {
        CheckMoveHorizontal(character);
        CheckJump(character);
    }

    void CheckMoveHorizontal(CharacterBase character)
    {
        float xInput = Input.GetAxis("Horizontal");   
        character.MoveHorizontal(xInput);
    }

    void CheckJump(CharacterBase character)
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            character.Jump();
        }
    }
}
