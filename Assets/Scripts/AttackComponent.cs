
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
        currentCharacterState = character.GetCharacterState();
    }

    private void Attack()
    {
        Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPoint.transform.position, attackRadius, character.enemiesLayerMask); 

        foreach (Collider2D enemy in enemies)
        {
            enemy.GetComponent<CharacterBase>().SetCharacterState(characterState.hurt);
        }
    }
}
