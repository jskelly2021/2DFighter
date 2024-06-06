
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

    void Awake()
    {
        character = GetComponent<CharacterBase>();
        InitStates();
        DisableStates();
        character.SetCharacterState(characterState.idle);
    }

    public void InitStates()
    {
        idle = character.gameObject.AddComponent<IdleStateMoveAction>();
        jump = character.gameObject.AddComponent<JumpStateMoveAction>();
        run = character.gameObject.AddComponent<RunStateMoveAction>();
    }

    public void DisableStates()
    {
        idle.enabled = false;
        jump.enabled = false;
        run.enabled = false;
    }

    public void ChangeMoveState()
    {
        DisableStates();

        switch (character.GetCharacterState())
        {
            case characterState.idle:
                idle.enabled = true;
                break;
            case characterState.jump:
                jump.enabled = true;
                break;
            case characterState.run:
                jump.enabled = true;
                break;
            default:
                break;
        }
    }

}
