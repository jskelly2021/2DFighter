
using UnityEngine;

public class AttackComponent : MonoBehaviour
{
    private CharacterBase character;
    private CharacterState currentCharacterState;
    
    public GameObject attackPoint;
    public float attackRadius = 1f;

    private void Awake()
    {
        character = gameObject.GetComponent<CharacterBase>();
        currentCharacterState = character.GetCharacterState();
    }

    private void Update()
    {
        if(currentCharacterState != character.GetCharacterState())
        {
            currentCharacterState = character.GetCharacterState();
            CheckAttack();
        }
    }

    private void CheckAttack()
    {
        if (currentCharacterState == CharacterState.Attack)
        {
            Attack();
        }
    }

    private void Attack()
    {
        Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPoint.transform.position, attackRadius, character.enemiesLayerMask); 

        foreach (Collider2D enemy in enemies)
        {
            CharacterBase enemyBase = enemy.GetComponentInParent<CharacterBase>();

            if (enemyBase != null)
                enemyBase.SetCharacterState(CharacterState.Hurt);
        }
    }

    // For testing
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(attackPoint.transform.position, attackRadius);
    }
}
