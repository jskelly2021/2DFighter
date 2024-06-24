
using UnityEngine.InputSystem;

public class PlayerController : CharacterController
{
    private CharacterBase characterBase;
    private PlayerInput playerInput;

    private InputAction horizontalMoveAction;
    private InputAction jumpAction;
    private InputAction attackAction;
    private InputAction blockAction;

    private void Awake()
    {
        characterBase = GetComponent<CharacterBase>();
        playerInput = GetComponent<PlayerInput>();

        if (playerInput == null)
        {
            print("No PlayerInput component found.");
            return;
        }

        horizontalMoveAction = playerInput.actions["HorizontalMove"];
        jumpAction = playerInput.actions["Jump"];
        attackAction = playerInput.actions["Attack"];
        blockAction = playerInput.actions["Block"];
    }

    private void OnEnable()
    {
        if (playerInput == null)
            return;

        horizontalMoveAction.started += OnMoveAction;
        horizontalMoveAction.performed += OnMoveAction;
        horizontalMoveAction.canceled += OnMoveAction;

        jumpAction.started += OnJumpAction;
        attackAction.started += OnAttackAction;

        blockAction.started += OnBlockAction;
        blockAction.canceled += OnBlockAction;
    }

    private void OnDisable()
    {
        if (playerInput == null)
            return;

        horizontalMoveAction.started -= OnMoveAction;
        horizontalMoveAction.performed -= OnMoveAction;
        horizontalMoveAction.canceled -= OnMoveAction;

        jumpAction.started -= OnJumpAction;
        attackAction.started -= OnAttackAction;

        blockAction.started -= OnBlockAction;
        blockAction.canceled -= OnBlockAction;
    }

    private void OnMoveAction(InputAction.CallbackContext context) => characterBase.CurrentVelocity = context.ReadValue<float>();

    private void OnJumpAction(InputAction.CallbackContext context) => InvokeJump();

    private void OnAttackAction(InputAction.CallbackContext context) => InvokeAttack();

    private void OnBlockAction(InputAction.CallbackContext context) => InvokeBlock();
}
