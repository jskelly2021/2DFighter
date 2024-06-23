
using UnityEngine;

public abstract class CharacterState : MonoBehaviour
{
    protected CharacterStateMachine stateMachine;
    protected CharacterBase character;
    protected CharacterController controller;
    protected Rigidbody2D body;

    private void Awake()
    {
        stateMachine = GetComponent<CharacterStateMachine>();
        character = GetComponent<CharacterBase>();
        controller = GetComponent<CharacterController>();
        body = character.body;
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

    private void Update()
    {
        IsGrounded();
    }

    protected virtual void IsGrounded()
    {

    }

    protected void FlipCharacter()
    {
        transform.localScale = new Vector2(character.LookDirection, transform.localScale.y);
    }

    protected abstract void MoveHorizontal(float direction);
    protected abstract void Crouch();
    protected abstract void Jump();
    protected abstract void Attack();
    protected abstract void Block();
}
