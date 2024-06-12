using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private CharacterBase character;
    private PlayerInput playerInput;
    private InputAction action;

    private void Awake()
    {
        character = GetComponent<CharacterBase>();
        
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    private void OnPerformed(InputAction.CallbackContext context)
    {
        
    }
    private void OnCancelled(InputAction.CallbackContext context)
    {

    }

}
