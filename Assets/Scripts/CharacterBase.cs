using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
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