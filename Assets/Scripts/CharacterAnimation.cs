
using UnityEngine;

public class CharacterAnimation : AnimationComponent
{
    [SerializeField] private Animator animator;
    public override void Play(characterState state)
    {
        switch (state)
        {
            case characterState.idle:
                animator.SetBool("")
                break;
            case characterState.run:
                break;
            case characterState.jump:
                break;
            case characterState.crouch:
                break;
            case characterState.hurt:
                break;
            case characterState.dead:
                break;
            default:
                break;
        }

    }
}
