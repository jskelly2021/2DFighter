
using UnityEngine;

public abstract class InputComponent : MonoBehaviour
{

    private void Awake()
    {
    }

    private void Update()
    {
        HandleInput();
    }

    protected abstract void HandleInput();
}
