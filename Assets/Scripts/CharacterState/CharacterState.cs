
using UnityEngine;

public abstract class CharacterState : MonoBehaviour
{
    protected CharacterBase character;
    protected CharacterController controller;
    protected Rigidbody2D body;

    private void Awake()
    {
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

    private void FixedUpdate()
    {
        MoveHorizontal(character.CurrentVelocity);
    }

    protected virtual void IsGrounded() {}

    protected void FlipCharacter()
    {
        transform.localScale = new Vector2(character.LookDirection, transform.localScale.y);
    }

    protected virtual void MoveHorizontal(float direction) { }
    protected virtual void Crouch() { }
    protected virtual void Jump() { }
    protected virtual void Attack() { }
    protected virtual void Block() { }
}
