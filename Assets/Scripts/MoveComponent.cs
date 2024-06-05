
using UnityEngine;

public abstract class MoveComponent : MonoBehaviour
{
    protected CharacterBase character;
    
    public void GetMovement(CharacterBase character)
    {
        this.character = character;
    }

    protected virtual void MoveHorizontal()
    {}

    protected virtual void Crouch()
    {}

    protected virtual void Jump()
    {}

    protected virtual void FlipPlayer(float direction)
    {}

    protected virtual void IsGrounded()
    {}
}
