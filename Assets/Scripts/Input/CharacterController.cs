
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class CharacterController : MonoBehaviour
{
    public event Action onMove;
    public event Action onJump;
    public event Action onAttack;
    public event Action onBlock;

    protected void OnMovePerformed(InputAction.CallbackContext context)
    {
        onMove?.Invoke();
    }

    protected void OnJumpPerformed(InputAction.CallbackContext context)
    {
        onJump?.Invoke();
    }

    protected void OnAttackPerformed(InputAction.CallbackContext context)
    {
        onAttack?.Invoke();
    }

    protected void OnBlockPerformed(InputAction.CallbackContext context)
    {
        onBlock?.Invoke();
    }
}
