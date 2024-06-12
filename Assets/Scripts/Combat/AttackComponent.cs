
using UnityEngine;

public abstract class AttackComponent : MonoBehaviour
{
    protected CharacterBase character;
    protected CharacterState currentCharacterState;
    
    [SerializeField] protected GameObject attackPoint;
    [SerializeField] protected float attackRadius = 0.25f;

    private void Awake()
    {
        character = gameObject.GetComponent<CharacterBase>();
        currentCharacterState = character.GetCharacterState();
    }

    private void Update()
    {
        HandleAttack();
    }

    protected void HandleAttack()
    {
        if (currentCharacterState == character.GetCharacterState())
            return;
        
        currentCharacterState = character.GetCharacterState();
        Attack();
    }

    protected void Attack()
    {
        switch(currentCharacterState)
        {
            case CharacterState.NuetralAttack:
                NuetralAttack(); 
                break;

            case CharacterState.FrontAttack:
                FrontAttack();
                break;
            
            case CharacterState.BackAttack:
                BackAttack();
                break;

            case CharacterState.HighAttack:
                HighAttack();
                break;

            case CharacterState.LowAttack:
                LowAttack();
                break;

            default:
                break;
        }
    }

    protected void MeleeAttack()
    {
        Collider2D[] opponents = Physics2D.OverlapCircleAll(attackPoint.transform.position, attackRadius, character.enemiesLayerMask);

        foreach (Collider2D opponent in opponents)
        {
            HealthComponent opponentHealth = opponent.GetComponentInParent<HealthComponent>();

            if (opponentHealth == null)
                continue;
            if (opponentHealth == gameObject.GetComponent<HealthComponent>())
                continue;

            opponentHealth.TakeDamage(1);

            Vector2 knockBackDirection = new Vector2(-1, 1);
            if (character.IsFacingRight)
                knockBackDirection = new Vector2(1, 1);

            opponentHealth.KnockBack(knockBackDirection, character.KnockBackForce);
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
