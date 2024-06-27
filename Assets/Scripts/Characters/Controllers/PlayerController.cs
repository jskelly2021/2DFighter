
using UnityEngine.InputSystem;

public class PlayerController : CharacterController
{
    private CharacterBase characterBase;
    private PlayerInput playerInput;

    private InputAction horizontalMoveAction;
    private InputAction jumpAction;
    private InputAction attackAction;
    private InputAction blockAction;
    private InputAction pauseAction;

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
        pauseAction = playerInput.actions["Pause"];
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
        attackAction.canceled += OnAttackAction;

        blockAction.started += OnBlockAction;
        blockAction.canceled += OnBlockAction;

        pauseAction.started += OnPauseAction;
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
        attackAction.canceled -= OnAttackAction;

        blockAction.started -= OnBlockAction;
        blockAction.canceled -= OnBlockAction;

        pauseAction.started -= OnPauseAction;
    }

    private void OnMoveAction(InputAction.CallbackContext context) => characterBase.CurrentVelocity = context.ReadValue<float>();

    private void OnJumpAction(InputAction.CallbackContext context) => InvokeJump();

    private void OnAttackAction(InputAction.CallbackContext context) => InvokeAttack();

    private void OnBlockAction(InputAction.CallbackContext context) => InvokeBlock();

    private void OnPauseAction(InputAction.CallbackContext context) => GameManager.Instance.PauseGame();
}
