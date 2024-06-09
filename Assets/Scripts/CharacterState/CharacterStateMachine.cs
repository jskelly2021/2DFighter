
using UnityEngine;

public class CharacterStateMachine : MonoBehaviour
{
    private CharacterBase character;

    private BaseCharacterState idle;
    private BaseCharacterState run;
    private BaseCharacterState jump;
    private BaseCharacterState crouch;
    private BaseCharacterState hurt;
    private BaseCharacterState dead;
    private BaseCharacterState attack;

    private CharacterState currentCharacterState;

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
        idle = character.gameObject.AddComponent<IdleState>();
        jump = character.gameObject.AddComponent<JumpState>();
        run = character.gameObject.AddComponent<RunState>();
        crouch = character.gameObject.AddComponent<CrouchState>();
        hurt = character.gameObject.AddComponent<HurtState>();
        dead = character.gameObject.AddComponent<DeadState>();
        attack = character.gameObject.AddComponent<AttackState>();

        DisableAllStates();
    }

    public void DisableAllStates()
    {
        idle.enabled = false;
        jump.enabled = false;
        run.enabled = false;
        crouch.enabled = false;
        hurt.enabled = false;
        dead.enabled = false;
        attack.enabled = false;
    }

    private void ChangeMoveState()
    {
        DisableAllStates();

        switch (currentCharacterState)
        {
            case CharacterState.Idle:
                idle.enabled = true;
                break;
            
            case CharacterState.Run:
                run.enabled = true;
                break;
            
            case CharacterState.Jump:
                jump.enabled = true;
                break;
            
            case CharacterState.Crouch:
                crouch.enabled = true;
                break;
            
            case CharacterState.Hurt:
                hurt.enabled = true;
                break;
            
            case CharacterState.Dead:
                dead.enabled = true;
                break;

            case CharacterState.NuetralAttack:
            case CharacterState.FrontAttack:
            case CharacterState.BackAttack:
            case CharacterState.HighAttack:
            case CharacterState.LowAttack:
                attack.enabled = true;
                break;

            default:
                break;
        }
    }

}
