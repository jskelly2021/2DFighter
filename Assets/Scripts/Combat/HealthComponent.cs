
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
        if (currentCharacterState != character.GetCharacterState())
        {
            currentCharacterState = character.GetCharacterState();
            CheckIfDamaged();
        }
    }

    private void CheckIfDamaged()
    {
        if (character.GetCharacterState() == CharacterState.Hurt)
        {
            TakeDamage(1);
            PlayerKnockedBack();
        }
    }

    private void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            character.SetCharacterState(CharacterState.Dead);
        }
    }

    private void PlayerKnockedBack()
    {
        character.body.velocity = new Vector2(character.KnockBackForce, character.KnockBackForce);
    }
}
