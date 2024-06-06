
using Unity.VisualScripting;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public Rigidbody2D body;
    public BoxCollider2D groundCheck;
    public LayerMask groundLayerMask;

    public float speed = 5f;
    public float jumpForce = 5f;

    private float direction = 0f;
    private bool isJumping = false;
    private bool isCrouching = false;

    private bool isFacingRight = true;
    private bool isGrounded = true;

    public InputComponent input;
    public MoveComponent movement;
    public AnimationComponent anim;

    private characterState state = characterState.start;

    public void SetCharacterState(characterState newState)
    {
        if (state != newState)
        {
            this.state = newState;
            anim.Play(state);
            movement.ChangeMoveState();
        }
    }

    public characterState GetCharacterState() 
    { 
        return state; 
    }

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
}
