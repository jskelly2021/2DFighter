
using UnityEngine;

public class AttackComponent : MonoBehaviour
{
    private CharacterBase character;
    private characterState currentCharacterState;
    
    public GameObject attackPoint;
    public float attackRadius;

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
        if (currentCharacterState == characterState.attack)
        {
            Attack();
        }
    }

    private void Attack()
    {
        Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPoint.transform.position, attackRadius, character.enemiesLayerMask); 

        foreach (Collider2D enemy in enemies)
        {
            Debug.Log("Attacking Enemy: " + enemy.name);
            enemy.GetComponent<CharacterBase>().SetCharacterState(characterState.hurt);
            Debug.Log("Successful Attack on: " + enemy.name);

        }
    }
}
