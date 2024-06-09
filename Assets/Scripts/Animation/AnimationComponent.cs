
using UnityEngine;

public abstract class AnimationComponent : MonoBehaviour
{
    [SerializeField] protected Animator animator;
 
    protected CharacterBase character;
    protected CharacterState currentCharacterState;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
        currentCharacterState = character.GetCharacterState();
    }

    private void Update()
    {
        HandleAnimations();
    }

    protected abstract void HandleAnimations();

    protected abstract void Play();
}
