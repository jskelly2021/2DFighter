
using UnityEngine;

public abstract class CharacterState : MonoBehaviour
{
    protected CharacterStateMachine stateMachine;
    protected CharacterInfo stats;
    protected CharacterController controller;
    protected Rigidbody2D body;

    private void Awake()
    {
        stateMachine = GetComponent<CharacterStateMachine>();
        stats = GetComponent<CharacterInfo>();
        controller = GetComponent<CharacterController>();
        body = stats.body;
    }

    private void OnEnable()
    {
        controller.onMove += MoveHorizontal;
        controller.onJump += Jump;
        controller.onAttack += Attack;
        controller.onBlock += Block;
    }

    private void OnDisable()
    {
        controller.onMove -= MoveHorizontal;
        controller.onJump -= Jump;
        controller.onAttack -= Attack;
        controller.onBlock -= Block;
    }

    protected void FlipCharacter()
    {
        transform.localScale = new Vector2(stats.LookDirection, transform.localScale.y);
    }

    protected abstract void MoveHorizontal(float direction);
    protected abstract void Crouch();
    protected abstract void Jump();
    protected abstract void Attack();
    protected abstract void Block();
}
