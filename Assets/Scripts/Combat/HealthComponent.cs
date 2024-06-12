
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public int health = 5;
    public int maxHealth = 5;

    private CharacterBase character;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
    }

    public void TakeDamage(int damage)
    {
        character.SetCharacterState(CharacterState.Hurt);
        health -= damage;

        if(health <= 0)
        {
            health = 0;
            character.SetCharacterState(CharacterState.Dead);
        }
    }

    public void KnockBack(Vector2 hitDirection, float knockBackForce)
    {
        character.body.velocity = new Vector2(hitDirection.x * knockBackForce, hitDirection.y * knockBackForce);
    }
}
