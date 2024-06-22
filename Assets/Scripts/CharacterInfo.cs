
using UnityEngine;

public class CharacterInfo
{
    public Rigidbody2D body;
    public BoxCollider2D groundCheck;
    public LayerMask groundLayerMask;
    public LayerMask opponentLayerMask;

    public float speed = 5f;
    public float jumpForce = 5f;
    public float knockBackForce = 5f;
    public int extraJumps = 1;

    [SerializeField] private int lookDirection = 1;
    [SerializeField] private bool isGrounded = true;

    public int LookDirection
    {
        get
        {
            if (body.velocity.x < 0 && lookDirection < 1)
                lookDirection = -1;

            else if (body.velocity.x > 0 && lookDirection < 1)
                lookDirection = 1;

            return lookDirection;
        }
    }

    public bool IsGrounded
    {
        get 
        { 
            isGrounded = groundCheck.IsTouchingLayers(groundLayerMask);
            return isGrounded;
        }
    }
}
