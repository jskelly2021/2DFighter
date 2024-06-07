
using UnityEngine;

public abstract class InputComponent : MonoBehaviour
{
    protected CharacterBase character;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
    }
}
