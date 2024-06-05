
using UnityEngine;

public class JumpStateMoveAction : MoveComponent
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 5f;

    private float walkDirection = 0f;
    private bool isJumping = false;
    private bool isCrouching = false;

    void Update()
    {
        IsGrounded();
        walkDirection = character.GetDirection();
        isJumping = character.GetJumping();
        isCrouching = character.GetCrouching();
    }

    private void FixedUpdate()
    {
        MoveHorizontal();
    }

    public override void MoveHorizontal()
    {
        body.velocity = new Vector2(walkDirection * speed, body.velocity.y);
        FlipCharacter(body.velocity.x);
    }

    public override void IsGrounded()
    {
        if (character.groundCheck.IsTouchingLayers(groundLayerMask))
        {
            isGrounded = true;
            character.SetCharacterState(characterState.idle);
        }
        else
        {
            isGrounded = false;
        }
    }

}
