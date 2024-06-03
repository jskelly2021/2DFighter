using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMovement : MonoBehaviour
{
    [SerializeField] private CharacterBase character;
    private float xInput;
    
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        HandleHorizontalMove();
        HandleJump();
        HandleCrouch();
    }

    // Movement
    void HandleHorizontalMove()
    {
        character.MoveHorizontal(xInput);
    }

    // Jumping
    void HandleJump()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
            character.Jump();
    }

    // Crouching
    void HandleCrouch()
    {
        character.Crouch(Input.GetKey(KeyCode.S));
    }

}
