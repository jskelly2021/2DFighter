
using Unity.VisualScripting;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public Rigidbody2D body;
    public BoxCollider2D groundCheck;
    public LayerMask groundLayerMask;

    public InputComponent input;
    public MoveComponent movement;
    public AnimationComponent anim;

    public float speed = 5f;
    public float jumpForce = 5f;
    private float direction = 0f;
    private bool isJumping = false;
    private bool isCrouching = false;
    private bool isFacingRight = true;
    private bool isGrounded = true;

    private characterState state = characterState.idle;

    public void SetCharacterState(characterState newState)
    {
        if (state != newState)
        {
            this.state = newState;
            anim.Play(state);
        }
        movement.ChangeMoveState();
    }

    public characterState GetCharacterState() 
    { 
        return state; 
    }

    public void SetDirection (float input) { direction = input; }
    public float GetDirection() { return direction; }

    public void SetJumping(bool input) { isJumping = input; }
    public bool GetJumping() { return isJumping; }

    public void SetCrouching(bool input) { isCrouching = input; }
    public bool GetCrouching() { return isCrouching; }


    public void SetFacingRight(bool input) { isFacingRight = input; }
    public bool IsFacingRight() { return isFacingRight; }

    public void SetGrounded(bool input) { isGrounded = input; }
    public bool IsGrounded() { return isGrounded; }
}
