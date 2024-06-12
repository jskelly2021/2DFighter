
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CharacterAnimation : AnimationComponent
{
    protected override void HandleAnimations()
    {
        if (character.GetCharacterState() != currentCharacterState)
        {
            currentCharacterState = character.GetCharacterState();
            Play();
        }
    }

    protected override void Play()
    {
        switch (currentCharacterState)
        {
            case CharacterState.Idle:
                animator.SetTrigger("idle");
                break;

            case CharacterState.Run:
                animator.SetTrigger("run");
                break;

            case CharacterState.Jump:
                animator.SetTrigger("jump");
                break;

            case CharacterState.Crouch:
                animator.SetTrigger("crouch");
                break;

            case CharacterState.Hurt:
                animator.SetTrigger("hurt");
                break;

            case CharacterState.Dead:
                animator.SetTrigger("dead");
                break;
            
            case CharacterState.Block:
                animator.SetTrigger("block");
                break;


            // Attacks
            case CharacterState.NuetralAttack:
                animator.SetTrigger("attackOverhead");
                break;

            case CharacterState.FrontAttack:
                animator.SetTrigger("attackFront");
                break;

            case CharacterState.BackAttack:
                animator.SetTrigger("attackBack");
                break;

            case CharacterState.HighAttack:
                animator.SetTrigger("attackOverhead");
                break;
  
            case CharacterState.LowAttack:
                animator.SetTrigger("attackBack");
                break;

            default:
                animator.SetTrigger("idle");
                break;
        }

    }
}
