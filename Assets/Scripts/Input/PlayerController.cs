using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private CharacterBase character;
    private PlayerInput playerInput;

    private InputAction horizontalMoveAction;
    private InputAction jumpAction;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
        playerInput = GetComponent<PlayerInput>();

        horizontalMoveAction = playerInput.actions["HorizontalMove"];
        jumpAction = playerInput.actions["Jump"];
    }

    private void OnEnable()
    {
        horizontalMoveAction.performed += OnHorizontalMovePerformed;
        jumpAction.performed += OnJumpPerformed;

        horizontalMoveAction.canceled += OnHorizontalMoveCancelled;
        jumpAction.canceled += OnJumpCancelled;
    }

    private void OnDisable()
    {
        horizontalMoveAction.performed -= OnHorizontalMovePerformed;
        jumpAction.performed -= OnJumpPerformed;

        horizontalMoveAction.canceled -= OnHorizontalMoveCancelled;
        jumpAction.canceled -= OnJumpCancelled;
    }

    private void OnHorizontalMovePerformed(InputAction.CallbackContext context)
    {
        character.Direction = context.ReadValue<float>();
    }
    private void OnHorizontalMoveCancelled(InputAction.CallbackContext context)
    {
        character.Direction = 0f;
    }

    private void OnJumpPerformed(InputAction.CallbackContext context)
    {
        character.IsJumping = context.action.triggered;
    }
    private void OnJumpCancelled(InputAction.CallbackContext context)
    {
        character.IsJumping = context.action.triggered;

    }
}
