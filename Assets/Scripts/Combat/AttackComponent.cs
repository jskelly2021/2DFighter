
using UnityEngine;

public abstract class AttackComponent : MonoBehaviour
{
    protected CharacterBase character;
    protected CharacterState currentCharacterState;
    
    [SerializeField] protected GameObject attackPoint;
    [SerializeField] protected float attackRadius = 1f;

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
        if (currentCharacterState != character.GetCharacterState())
        {
            currentCharacterState = character.GetCharacterState();
            return;
        }

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
        Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPoint.transform.position, attackRadius, character.enemiesLayerMask);

        foreach (Collider2D enemy in enemies)
        {
            CharacterBase enemyBase = enemy.GetComponentInParent<CharacterBase>();

            if (enemyBase != null)
                enemyBase.SetCharacterState(CharacterState.Hurt);
        }
    }

    protected virtual void NuetralAttack() { }
    protected virtual void FrontAttack() { }
    protected virtual void BackAttack() { }
    protected virtual void HighAttack() { }
    protected virtual void LowAttack() { }


    // For testing
    private void OnDrawGizmos()
    {
        if (attackPoint != null)
            Gizmos.DrawWireSphere(attackPoint.transform.position, attackRadius);
    }
}
