
using Unity.VisualScripting;
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

    public void SetCharacterState(characterState newState) { this.state = newState; }
    public characterState GetCharacterState() { return state; }

    public void SetWalkDirection (float input) { direction = input; }
    public float GetWalkDirection() { return direction; }

    public void SetJumping(bool input) { isJumping = input; }
    public bool IsJumping() { return isJumping; }

    public void SetCrouching(bool input) { isCrouching = input; }
    public bool IsCrouching() { return isCrouching; }

    public void SetFacingRight(bool input) { isFacingRight = input; }
    public bool IsFacingRight() { return isFacingRight; }

    public void SetGrounded(bool input) { isGrounded = input; }
    public bool IsGrounded() { return isGrounded; }

    public void SetHurt(bool input) { isHurt = input; }
    public bool IsHurt() { return isHurt; }

    public void SetStunTime(float input) { stunTime = input; }
    public float GetStunTime() { return stunTime; }

    public void SetDead(bool input) { isDead = input; }
    public bool IsDead() { return isDead; }

    public void SetAttack(bool input) { isAttacking = input; }
    public bool IsAttacking() { return isAttacking; }
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
