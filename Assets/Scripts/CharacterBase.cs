
using System;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public Rigidbody2D body;
    public BoxCollider2D groundCheck;
    public LayerMask groundLayerMask;
    public LayerMask enemiesLayerMask;

    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float knockBackForce = 5f;
    [SerializeField] private int extraJumps = 1;


    public float Speed 
    { 
        get { return speed; }
        set { speed = value; } 
    }
    public float JumpForce
    {
        get { return jumpForce; }
        set { jumpForce = value; }
    }
    public float KnockBackForce
    {
        get { return knockBackForce; }
        set { knockBackForce = value; }
    }
    public int ExtraJumps
    {
        get { return extraJumps; }
    }

    public float Direction { get; set; } = 0f;


    public bool IsCrouching { get; set; } = false;
    public bool IsFacingRight { get; set; } = true;
    public bool IsGrounded { get; set; } = true;
    public bool IsDead { get; set; } = false;
    public bool IsAttacking { get; set; } = false;
    public bool IsBlocking { get; set; } = false;
    public int extraJumpsLeft { get; set; } = 1;

    private CharacterState state = CharacterState.Idle;
    public void SetCharacterState(CharacterState newState) => state = newState;
    public CharacterState GetCharacterState() => state;
}
