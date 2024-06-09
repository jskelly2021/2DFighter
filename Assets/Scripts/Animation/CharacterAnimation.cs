
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CharacterAnimation : AnimationComponent
{
    public override void Play()
    {
        switch (currentCharacterState)
        {
            case characterState.idle:
                animator.SetTrigger("idle");
                break;
            case characterState.run:
                animator.SetTrigger("run");
                break;
            case characterState.jump:
                animator.SetTrigger("jump");
                break;
            case characterState.crouch:
                animator.SetTrigger("crouch");
                break;
            case characterState.hurt:
                animator.SetTrigger("hurt");
                break;
            case characterState.dead:
                animator.SetTrigger("dead");
                break;
            case characterState.attack:
                animator.SetTrigger("attackFront");
                break;
            default:
                break;
        }

    }
}
