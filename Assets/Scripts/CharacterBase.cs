using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class CharacterBase : MonoBehaviour
{
    [SerializeField] private InputComponent input;
    [SerializeField] private MoveComponent movement;
    [SerializeField] private AnimationComponent anim;

    private characterState state = characterState.idle;
    void Start()
    {
        input.GetInput(this);
        movement.GetMovement(this);
    }

    public characterState GetCharacterState()
    {
        return state;
    }

    public void SetCharacterState(characterState newState)
    {
        this.state = newState;
        anim.Play(state);
    }

    private Vector2 velocity = Vector2.zero;
    private bool isJumping = false;
    private bool isCrouching = false;

    public void SetHorizontalVelocity(float input) { velocity.x = input; }
    public Vector2 GetHorizontalVelocity() { return velocity; }

    public void SetJumping(bool input) { isJumping = input; }
    public bool GetJumping(bool input) { return isJumping; }

    public void SetCrouching(bool input) { isCrouching = input; }
    public bool GetCrouching(bool input) { return isCrouching; }

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