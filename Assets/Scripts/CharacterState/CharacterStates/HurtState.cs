
using System.Collections;
using UnityEngine;

public class HurtState : BaseCharacterState
{
    private void OnEnable()
    {
        StartCoroutine(StunTimer());
    }

    IEnumerator StunTimer()
    {
        yield return new WaitForSeconds(character.stunTime);

        if (character.GetCharacterState() != characterState.dead)
        {
            character.SetCharacterState(characterState.idle);
        }
    }
}