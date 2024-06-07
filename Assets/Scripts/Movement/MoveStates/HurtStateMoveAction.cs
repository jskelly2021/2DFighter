
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
        character.SetCharacterState(characterState.idle);
    }
}
