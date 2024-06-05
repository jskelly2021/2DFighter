
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

    private characterState state = characterState.idle;

    void Start()
    {
        input.InitInput(this);
        movement = GetComponent<IdleStateMoveAction>();
        movement.InitMovement(this);
    }

    public void SetCharacterState(characterState newState)
    {
        this.state = newState;
        movement = movement.ChangeMoveState();
        movement.InitMovement(this);
        anim.Play(state);
    }
    public characterState GetCharacterState() { return state; }

    private float direction = 0f;
    private bool isJumping = false;
    private bool isCrouching = false;

    public void SetDirection (float input) { direction = input; }
    public float GetDirection() { return direction; }

    public void SetJumping(bool input) { isJumping = input; }
    public bool GetJumping() { return isJumping; }

    public void SetCrouching(bool input) { isCrouching = input; }
    public bool GetCrouching() { return isCrouching; }

}


public enum characterState
{
    idle,
    run,
    jump,
    crouch,
    hurt,
    dead
}