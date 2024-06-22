
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class PlayerController : CharacterController
{
    private PlayerInput playerInput;

    private InputAction horizontalMoveAction;
    private InputAction jumpAction;
    private InputAction attackAction;
    private InputAction blockAction;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();

        horizontalMoveAction = playerInput.actions["HorizontalMove"];
        jumpAction = playerInput.actions["Jump"];
        attackAction = playerInput.actions["Attack"];
        blockAction = playerInput.actions["Block"];
    }

    private void OnEnable()
    {
        horizontalMoveAction.performed += OnMovePerformed;
        jumpAction.performed += OnJumpPerformed;
        attackAction.performed += OnAttackPerformed;
        blockAction.performed += OnBlockPerformed;
    }

    private void OnDisable()
    {
        horizontalMoveAction.performed -= OnMovePerformed;
        jumpAction.performed -= OnJumpPerformed;
        attackAction.performed -= OnAttackPerformed;
        blockAction.performed -= OnBlockPerformed;
    }
}
