
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public Rigidbody2D body;
    public BoxCollider2D groundCheck;
    public LayerMask groundLayerMask;
    public LayerMask enemiesLayerMask;

    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float stunTime = 0.2f;

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
    public float StunTime
    {
        get { return stunTime; }
        set { stunTime = value; }
    }

    public float Direction { get; set; } = 0f;
    public bool IsJumping { get; set; } = false;
    public bool IsCrouching { get; set; } = false;
    public bool IsFacingRight { get; set; } = true;
    public bool IsGrounded { get; set; } = true;
    public bool IsHurt { get; set; } = false;
    public bool IsDead { get; set; } = false;
    public bool IsAttacking { get; set; } = false;

    private CharacterState state = CharacterState.Idle;
    public void SetCharacterState(CharacterState newState) => state = newState;
    public CharacterState GetCharacterState() => state;

}

