
using Unity.VisualScripting;
using UnityEngine;

public class MoveComponent : MonoBehaviour
{
    private CharacterBase character;

    private CharacterState currentCharacterState;

    public void InitMove(CharacterBase character)
    {
        this.character = character;

        currentCharacterState = character.gameObject.AddComponent<IdleStateMoveAction>();
        currentCharacterState.InitState(character);
        
        character.SetCharacterState(characterState.idle);
    }

    public CharacterState ChangeMoveState()
    {
        switch (character.GetCharacterState())
        {
            case characterState.idle:
                currentCharacterState = character.gameObject.AddComponent<IdleStateMoveAction>();
                break;
            case characterState.jump:
                currentCharacterState = character.gameObject.AddComponent<JumpStateMoveAction>();
                break;
            default:
                return currentCharacterState;
        }

        currentCharacterState.InitState(character);
        return currentCharacterState;
    }

}
