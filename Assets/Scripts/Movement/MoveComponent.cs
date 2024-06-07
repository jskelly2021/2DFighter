
using Unity.VisualScripting;
using UnityEngine;

public class MoveComponent : MonoBehaviour
{
    private CharacterBase character;

    private CharacterState idle;
    private CharacterState run;
    private CharacterState jump;
    private CharacterState crouch;
    private CharacterState hurt;
    private CharacterState dead;

    private characterState currentCharacterState;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
        InitStates();

        currentCharacterState = character.GetCharacterState();
        ChangeMoveState();
    }

    private void Update()
    {
        if (character.GetCharacterState() != currentCharacterState)
        {
            currentCharacterState = character.GetCharacterState();
            ChangeMoveState();
        }
    }

    private void InitStates()
    {
        idle = character.gameObject.AddComponent<IdleStateMoveAction>();
        jump = character.gameObject.AddComponent<JumpStateMoveAction>();
        run = character.gameObject.AddComponent<RunStateMoveAction>();
        crouch = character.gameObject.AddComponent<CrouchStateMoveAction>();

        DisableAllStates();
    }

    public void DisableAllStates()
    {
        idle.enabled = false;
        jump.enabled = false;
        run.enabled = false;
        crouch.enabled = false;
    }

    private void ChangeMoveState()
    {
        DisableAllStates();

        switch (currentCharacterState)
        {
            case characterState.idle:
                idle.enabled = true;
                break;
            case characterState.run:
                run.enabled = true;
                break;
            case characterState.jump:
                jump.enabled = true;
                break;
            case characterState.crouch:
                crouch.enabled = true;
                break;
            case characterState.hurt:
                break;
            case characterState.dead:
                break;
            default:
                break;
        }
    }

}
