
using UnityEngine;

public class CharacterAnimation : AnimationComponent
{
    [SerializeField] private Animator animator;
    public override void Play(characterState state)
    {
        switch (state)
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
            default:
                break;
        }

    }
}
