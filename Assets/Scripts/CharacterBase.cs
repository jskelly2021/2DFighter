
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public Rigidbody2D body;
    public BoxCollider2D groundCheck;
    public LayerMask groundLayerMask;
    public LayerMask enemiesLayerMask;

    public float speed = 5f;
    public float jumpForce = 5f;
    public float stunTime = 0.5f;

    private float direction = 0f;
    private bool isJumping = false;
    private bool isCrouching = false;

    private bool isFacingRight = true;
    private bool isGrounded = true;

    private bool isHurt = false;
    private bool isDead = false;

    private bool isAttacking = false;

    private characterState state = characterState.idle;

    public void SetCharacterState(characterState newState) => state = newState;
    public characterState GetCharacterState() => state;

    public void SetWalkDirection(float input) => direction = input;
    public float GetWalkDirection() => direction;

    public void SetJumping(bool input) => isJumping = input;
    public bool IsJumping() => isJumping;

    public void SetCrouching(bool input) => isCrouching = input;
    public bool IsCrouching() => isCrouching;

    public void SetFacingRight(bool input) => isFacingRight = input;
    public bool IsFacingRight() => isFacingRight;

    public void SetGrounded(bool input) => isGrounded = input;
    public bool IsGrounded() => isGrounded;

    public void SetHurt(bool input) => isHurt = input;
    public bool IsHurt() => isHurt;

    public void SetStunTime(float input) => stunTime = input;
    public float GetStunTime() => stunTime;

    public void SetDead(bool input) => isDead = input;
    public bool IsDead() => isDead;

    public void SetAttack(bool input) => isAttacking = input;
    public bool IsAttacking() => isAttacking;
}

public enum characterState
{
    idle,
    run,
    jump,
    crouch,
    hurt,
    dead,
    attack
}
