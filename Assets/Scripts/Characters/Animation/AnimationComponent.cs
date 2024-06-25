
using UnityEngine;

public abstract class AnimationComponent : MonoBehaviour
{
    [SerializeField] protected Animator animator;
    protected CharacterBase character;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
    }

    private void OnEnable()
    {
        character.onStateChange += Play;
    }

    private void OnDisable()
    {
        character.onStateChange -= Play;
    }

    protected abstract void Play(CharacterStates state);
}
