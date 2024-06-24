
using System;
using UnityEngine;

public abstract class CharacterController : MonoBehaviour
{
    public event Action onJump;
    public event Action onAttack;
    public event Action onBlock;

    protected void InvokeJump() => onJump?.Invoke();
    protected void InvokeAttack() => onAttack?.Invoke();
    protected void InvokeBlock() => onBlock?.Invoke();
}
