
using UnityEngine;

public abstract class AnimationComponent : MonoBehaviour
{
    public abstract void Play(CharacterBase.characterState state);
}
