
using UnityEngine;

public abstract class AttackComponent : MonoBehaviour
{
    protected CharacterBase character;
    
    [SerializeField] protected GameObject attackPoint;
    [SerializeField] protected float attackRadius = 0.25f;

    private void Awake()
    {
        character = gameObject.GetComponent<CharacterBase>();
    }

    private void OnEnable()
    {
        character.onStateChange += Attack;
    }

    protected void Attack(CharacterStates state)
    {
        switch(state)
        {
            case CharacterStates.NuetralAttack:
                NuetralAttack(); 
                break;

            case CharacterStates.FrontAttack:
                FrontAttack();
                break;
            
            case CharacterStates.BackAttack:
                BackAttack();
                break;

            case CharacterStates.HighAttack:
                HighAttack();
                break;

            case CharacterStates.LowAttack:
                LowAttack();
                break;

            default:
                break;
        }
    }

    protected void MeleeAttack()
    {
        Collider2D[] opponents = Physics2D.OverlapCircleAll(attackPoint.transform.position, attackRadius, character.opponentLayerMask);

        foreach (Collider2D opponent in opponents)
        {
            HealthComponent opponentHealth = opponent.GetComponentInParent<HealthComponent>();

            if (opponentHealth == null)
                continue;
            if (opponentHealth == gameObject.GetComponent<HealthComponent>())
                continue;

            opponentHealth.TakeDamage(1);

            Vector2 knockBackDirection = new Vector2(-1, 1);
            if (character.LookDirection > 0)
                knockBackDirection = new Vector2(1, 1);

            opponentHealth.KnockBack(knockBackDirection, character.HitForce);
        }
    }

    protected abstract void NuetralAttack();
    protected abstract void FrontAttack();
    protected abstract void BackAttack();
    protected abstract void HighAttack();
    protected abstract void LowAttack();


    // For testing
    private void OnDrawGizmos()
    {
        if (attackPoint != null)
            Gizmos.DrawWireSphere(attackPoint.transform.position, attackRadius);
    }
}
