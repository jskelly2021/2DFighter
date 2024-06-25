
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

    private void OnEnable() => SubscribeActions(true);

    private void OnDisable() => SubscribeActions(false);

    private void SubscribeActions(bool subscribe)
    {
        if (playerInput == null)
            return;

        if (subscribe)
        {
            horizontalMoveAction.started += OnMoveAction;
            horizontalMoveAction.performed += OnMoveAction;
            horizontalMoveAction.canceled += OnMoveAction;

            jumpAction.started += OnJumpAction;

            attackAction.started += OnAttackAction;
            attackAction.canceled += OnAttackAction;

            blockAction.started += OnBlockAction;
            blockAction.canceled += OnBlockAction;
            return;
        }

        horizontalMoveAction.started -= OnMoveAction;
        horizontalMoveAction.performed -= OnMoveAction;
        horizontalMoveAction.canceled -= OnMoveAction;

        jumpAction.started -= OnJumpAction;

        attackAction.started -= OnAttackAction;
        attackAction.canceled -= OnAttackAction;

        blockAction.started -= OnBlockAction;
        blockAction.canceled -= OnBlockAction;
    }

    private void OnMoveAction(InputAction.CallbackContext context) => characterBase.CurrentVelocity = context.ReadValue<float>();

    private void OnJumpAction(InputAction.CallbackContext context) => InvokeJump();

    private void OnAttackAction(InputAction.CallbackContext context) => InvokeAttack();

    private void OnBlockAction(InputAction.CallbackContext context) => InvokeBlock();
}
