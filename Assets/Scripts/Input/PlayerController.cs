using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private CharacterBase character;
    private PlayerInput playerInput;

    private InputAction horizontalMoveAction;
    private InputAction jumpAction;
    private InputAction attackAction;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
        playerInput = GetComponent<PlayerInput>();

        horizontalMoveAction = playerInput.actions["HorizontalMove"];
        jumpAction = playerInput.actions["Jump"];
        attackAction = playerInput.actions["Attack"];
    }

    private void OnEnable()
    {
        horizontalMoveAction.performed += OnHorizontalMovePerformed;
        jumpAction.performed += OnJumpPerformed;
        attackAction.performed += OnAttackPerformed;

        horizontalMoveAction.canceled += OnHorizontalMoveCancelled;
        jumpAction.canceled += OnJumpCancelled;
        attackAction.canceled += OnAttackCancelled;
    }

    private void OnDisable()
    {
        horizontalMoveAction.performed -= OnHorizontalMovePerformed;
        jumpAction.performed -= OnJumpPerformed;
        attackAction.performed -= OnAttackPerformed;

        horizontalMoveAction.canceled -= OnHorizontalMoveCancelled;
        jumpAction.canceled -= OnJumpCancelled;
        attackAction.canceled -= OnAttackCancelled;
    }

    private void OnHorizontalMovePerformed(InputAction.CallbackContext context)
    {
        character.Direction = context.ReadValue<float>();
    }
    private void OnHorizontalMoveCancelled(InputAction.CallbackContext context)
    {
        character.Direction = context.ReadValue<float>();
    }

    private void OnJumpPerformed(InputAction.CallbackContext context)
    {
        character.IsJumping = true;
    }
    private void OnJumpCancelled(InputAction.CallbackContext context)
    {
        character.IsJumping = false;
    }

    private void OnAttackPerformed(InputAction.CallbackContext context)
    {
        character.IsAttacking = true;
    }
    private void OnAttackCancelled(InputAction.CallbackContext context)
    {
        character.IsAttacking = false;
    }
}
