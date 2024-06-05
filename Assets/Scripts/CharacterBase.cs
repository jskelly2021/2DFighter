using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Windows;

public class CharacterBase : MonoBehaviour
{
    public Rigidbody2D body;
    public BoxCollider2D groundCheck;
    public LayerMask groundLayerMask;

    public InputComponent input;
    public MoveComponent action;
    public AnimationComponent anim;

    public float speed = 5f;
    public float jumpForce = 5f;

    private characterState state = characterState.idle;
    void Start()
    {
        input = gameObject.AddComponent<InputComponent>();
        action = gameObject.AddComponent<IdleStateMoveAction>();
    }

    public characterState GetCharacterState()
    {
        return state;
    }

    public void SetCharacterState(characterState newState)
    {
        this.state = newState;
        
        switch (state)
        {
            case characterState.idle:
                action = gameObject.AddComponent<IdleStateMoveAction>();
                break;
            case characterState.jump:
                action = gameObject.AddComponent<JumpStateMoveAction>();
                break;
            default:
                break;
        }

        anim.Play(state);
    }

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