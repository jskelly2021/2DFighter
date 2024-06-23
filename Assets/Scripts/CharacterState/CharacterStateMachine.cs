
using UnityEngine;

public class CharacterStateMachine : MonoBehaviour
{
    private CharacterState idle;
    private CharacterState run;
    private CharacterState jump;
    private CharacterState crouch;
    private CharacterState hurt;
    private CharacterState dead;
    private CharacterState attack;
    private CharacterState block;

    private CharacterBase character;
    [SerializeField] private CharacterState currentState;

    private void Awake()
    {
        character = gameObject.GetComponent<CharacterBase>();
        InitStates();
    }

    private void OnEnable()
    {
        character.onStateChange += ChangeCharacterState;
    }

    private void OnDisable()
    {
        character.onStateChange -= ChangeCharacterState;
    }

    private void InitStates()
    {
        idle = gameObject.AddComponent<IdleState>();
        run = gameObject.AddComponent<RunState>();
        jump = gameObject.AddComponent<JumpState>();
        crouch = gameObject.AddComponent<CrouchState>();
        hurt = gameObject.AddComponent<HurtState>();
        dead = gameObject.AddComponent<DeadState>();
        attack = gameObject.AddComponent<AttackState>();
        block = gameObject.AddComponent<BlockState>();

        idle.enabled = false;
        jump.enabled = false;
        run.enabled = false;
        crouch.enabled = false;
        hurt.enabled = false;
        dead.enabled = false;
        attack.enabled = false;
        block.enabled = false;

        currentState = idle;
        currentState.enabled = true;
    }

    public void ChangeCharacterState(CharacterStates nextState)
    {
        currentState.enabled = false;

        switch (nextState)
        {
            case CharacterStates.Idle:
                currentState = idle;
                break;

            case CharacterStates.Run:
                currentState = run;
                break;

            case CharacterStates.Jump:
                currentState = jump;
                break;

            case CharacterStates.Crouch:
                currentState = crouch;
                break;

            case CharacterStates.Hurt:
                currentState = hurt;
                break;

            case CharacterStates.Dead:
                currentState = dead;
                break;

            case CharacterStates.Block:
                currentState = block;
                break;

            case CharacterStates.NuetralAttack:
            case CharacterStates.FrontAttack:
            case CharacterStates.BackAttack:
            case CharacterStates.HighAttack:
            case CharacterStates.LowAttack:
                currentState = attack;
                break;

            default:
                break;
        }
        currentState.enabled = true;
    }

}
