
using System;
using UnityEngine;

public abstract class CharacterController : MonoBehaviour
{
    public event Action onJump;
    public event Action onAttack;
    public event Action onBlock;
    public event Action onPause;

    protected void InvokeJump() => onJump?.Invoke();
    protected void InvokeAttack() => onAttack?.Invoke();
    protected void InvokeBlock() => onBlock?.Invoke();
    protected void InvokePause() => onPause?.Invoke();
}
