
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

    [SerializeField] private CharacterState currentState;

    private void Awake()
    {
        InitStates();
    }

    private void InitStates()
    {
        idle = gameObject.AddComponent<IdleState>();
        jump = gameObject.AddComponent<JumpState>();
        run = gameObject.AddComponent<RunState>();
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

    private void ChangeCharacterState(CharacterState nextState)
    {
        currentState.enabled = false;

        currentState = nextState;
        currentState.enabled = true;
    }

}
