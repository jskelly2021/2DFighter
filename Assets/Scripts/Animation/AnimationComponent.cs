
using UnityEngine;

public abstract class AnimationComponent : MonoBehaviour
{
    [SerializeField] protected Animator animator;
 
    protected CharacterBase character;
    protected characterState currentCharacterState;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
        currentCharacterState = character.GetCharacterState();
    }

    private void Update()
    {
        if (character.GetCharacterState() != currentCharacterState)
        {
            currentCharacterState = character.GetCharacterState();
            Play();
        }
    }

    public abstract void Play();
}
