
using System;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public Rigidbody2D body;
    public BoxCollider2D groundCheck;
    public LayerMask groundLayerMask;
    public LayerMask opponentLayerMask;

    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float hitForce = 5f;
    [SerializeField] private int numExtraJumps = 1;
    [SerializeField] private int extraJumpsLeft = 1;

    [SerializeField] private float currentVelocity = 0;
    [SerializeField] private int lookDirection = 1;
    [SerializeField] private bool isGrounded = true;

    [SerializeField] private CharacterStates currentState = CharacterStates.Idle;
    public event Action<CharacterStates> onStateChange;
    
    public float Speed 
    { 
        get { return speed; } 
    }

    public float JumpForce
    {
        get { return jumpForce; }
    }

    public float HitForce
    {
        get { return hitForce; }
    }

    public int NumExtraJumps
    {
        get { return numExtraJumps; }
    }
    public int ExtraJumpsLeft
    {
        get { return extraJumpsLeft; }
        set { extraJumpsLeft = value; }
    }

    public float CurrentVelocity
    {
        get { return currentVelocity; }
        set { currentVelocity = value; }
    }

    public int LookDirection
    {
        get { return lookDirection; }
        set { lookDirection = value; }
    }

    public bool IsGrounded
    {
        get { return isGrounded; }
        set { isGrounded = value; }
    }

    public CharacterStates CurrentState
    {
        get { return currentState; }
        set
        {
            currentState = value;
            onStateChange?.Invoke(value);
        }
    }
}
