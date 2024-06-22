
using System;
using UnityEngine;

public abstract class CharacterController : MonoBehaviour
{
    public event Action<float> onMove;
    public event Action onJump;
    public event Action onAttack;
    public event Action onBlock;

    protected void InvokeMove(float value) => onMove?.Invoke(value);
    protected void InvokeJump() => onJump?.Invoke();
    protected void InvokeAttack() => onAttack?.Invoke();
    protected void InvokeBlock() => onBlock?.Invoke();
}
