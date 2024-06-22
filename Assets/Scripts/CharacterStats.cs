
using UnityEngine;

public class CharacterStats
{
    public Rigidbody2D body;
    public BoxCollider2D groundCheck;
    public LayerMask groundLayerMask;
    public LayerMask opponentLayerMask;

    public float speed = 5f;
    public float jumpForce = 5f;
    public float knockBackForce = 5f;
    public int extraJumps = 1;
}
