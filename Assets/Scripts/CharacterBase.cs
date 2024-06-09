
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public Rigidbody2D body;
    public BoxCollider2D groundCheck;
    public LayerMask groundLayerMask;
    public LayerMask enemiesLayerMask;

    public float speed { get; set; } = 5f;
    public float jumpForce { get; set; } = 5f;
    public float stunTime { get; set; } = 0.5f;
    public float direction { get; set; } = 0f;
    public bool isJumping { get; set; } = false;
    public bool isCrouching { get; set; } = false;
    public bool isFacingRight { get; set; } = true;
    public bool isGrounded { get; set; } = true;
    public bool isHurt { get; set; } = false;
    public bool isDead { get; set; } = false;
    public bool isAttacking { get; set; } = false;

    public characterState state { get; set; } = characterState.idle;
    public void SetCharacterState(characterState newState) => state = newState;
    public characterState GetCharacterState() => state;

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
