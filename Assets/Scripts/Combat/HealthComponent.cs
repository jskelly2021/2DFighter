
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public int health = 3;
    public int maxHealth = 5;

    private CharacterBase character;
    private CharacterState currentCharacterState;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
        currentCharacterState = character.GetCharacterState();
    }

    private void Update()
    {
        CheckIfDamaged();
    }

    private void CheckIfDamaged()
    {
        if (currentCharacterState == character.GetCharacterState())
            return;

        currentCharacterState = character.GetCharacterState();

        if (currentCharacterState == CharacterState.Dead)
            return;

        if (character.GetCharacterState() == CharacterState.Hurt)
        {
            TakeDamage(1);
            PlayerKnockedBack(new Vector2(1, 1), character.KnockBackForce);
        }
    }

    private void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            health = 0;
            character.SetCharacterState(CharacterState.Dead);
        }
    }

    private void PlayerKnockedBack(Vector2 hitDirection, float knockBackForce)
    {
        character.body.velocity = new Vector2(hitDirection.x * knockBackForce, hitDirection.y * knockBackForce);
    }
}
