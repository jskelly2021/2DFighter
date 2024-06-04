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


    public void MoveHorizontal(float input)
    {
    }

    public void Crouch(bool isCrouching)
    {
    }

    public void Jump()
    {
       
    }

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