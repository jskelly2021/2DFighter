
public class CharacterAnimation : AnimationComponent
{
    protected override void Play(CharacterStates state)
    {
        switch (state)
        {
            case CharacterStates.Idle:
                animator.SetTrigger("idle");
                break;

            case CharacterStates.Run:
                animator.SetTrigger("run");
                break;

            case CharacterStates.Jump:
                animator.SetTrigger("jump");
                break;

            case CharacterStates.Crouch:
                animator.SetTrigger("crouch");
                break;

            case CharacterStates.Hurt:
                animator.SetTrigger("hurt");
                break;

            case CharacterStates.Dead:
                animator.SetTrigger("dead");
                break;
            
            case CharacterStates.Block:
                animator.SetTrigger("block");
                break;


            // Attacks
            case CharacterStates.NuetralAttack:
                animator.SetTrigger("attackOverhead");
                break;

            case CharacterStates.FrontAttack:
                animator.SetTrigger("attackFront");
                break;

            case CharacterStates.BackAttack:
                animator.SetTrigger("attackBack");
                break;

            case CharacterStates.HighAttack:
                animator.SetTrigger("attackOverhead");
                break;
  
            case CharacterStates.LowAttack:
                animator.SetTrigger("attackBack");
                break;

            default:
                animator.SetTrigger("idle");
                break;
        }

    }
}
