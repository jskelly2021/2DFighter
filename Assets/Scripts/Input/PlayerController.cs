
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : CharacterController
{
    private CharacterBase character;
    private PlayerInput playerInput;

    private InputAction horizontalMoveAction;
    private InputAction jumpAction;
    private InputAction attackAction;
    private InputAction blockAction;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
        playerInput = GetComponent<PlayerInput>();

        horizontalMoveAction = playerInput.actions["HorizontalMove"];
        jumpAction = playerInput.actions["Jump"];
        attackAction = playerInput.actions["Attack"];
        blockAction = playerInput.actions["Block"];
    }

    private void OnEnable()
    {
        horizontalMoveAction.performed += OnHorizontalMovePerformed;
        jumpAction.performed += OnJumpPerformed;
        attackAction.performed += OnAttackPerformed;
        blockAction.performed += OnBlockPerformed;

        horizontalMoveAction.canceled += OnHorizontalMoveCancelled;
        //jumpAction.canceled += OnJumpCancelled;
        attackAction.canceled += OnAttackCancelled;
        blockAction.canceled += OnBlockCanceled;

    }

    private void OnDisable()
    {
        horizontalMoveAction.performed -= OnHorizontalMovePerformed;
        jumpAction.performed -= OnJumpPerformed;
        attackAction.performed -= OnAttackPerformed;
        blockAction.performed -= OnBlockPerformed;


        horizontalMoveAction.canceled -= OnHorizontalMoveCancelled;
        //jumpAction.canceled -= OnJumpCancelled;
        attackAction.canceled -= OnAttackCancelled;
        blockAction.canceled -= OnBlockCanceled;
    }

    private void OnHorizontalMovePerformed(InputAction.CallbackContext context) => character.Direction = context.ReadValue<float>();
    private void OnHorizontalMoveCancelled(InputAction.CallbackContext context) => character.Direction = context.ReadValue<float>();

    private void OnJumpPerformed(InputAction.CallbackContext context) => character.IsJumping();
    //private void OnJumpCancelled(InputAction.CallbackContext context) => character.IsJumping();

    private void OnAttackPerformed(InputAction.CallbackContext context) => character.IsAttacking = true;
    private void OnAttackCancelled(InputAction.CallbackContext context) => character.IsAttacking = false;

    private void OnBlockPerformed(InputAction.CallbackContext context) => character.IsBlocking = true;
    private void OnBlockCanceled(InputAction.CallbackContext context) => character.IsBlocking = false;
}
