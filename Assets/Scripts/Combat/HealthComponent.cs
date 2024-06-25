
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
        if (character.CurrentState == CharacterStates.Block)
            return;

        character.CurrentState = CharacterStates.Hurt;
        health -= damage;

        if(health <= 0)
        {
            health = 0;
            character.CurrentState = CharacterStates.Dead;
        }
    }

    public void KnockBack(Vector2 hitDirection, float knockBackForce)
    {
        if (character.CurrentState == CharacterStates.Block)
            return;

        character.body.velocity = new Vector2(hitDirection.x * knockBackForce, hitDirection.y * knockBackForce);
    }
}
