
using System.Collections;
using UnityEngine;

public class HurtStateMoveAction : CharacterState
{
    private void OnEnable()
    {
        StartCoroutine(StunTimer());
    }

    IEnumerator StunTimer()
    {
        yield return new WaitForSeconds(character.GetStunTime());

        if (character.GetCharacterState() != characterState.dead)
        {
            character.SetCharacterState(characterState.idle);
        }
    }
}
