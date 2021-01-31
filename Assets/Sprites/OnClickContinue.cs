using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OnClickContinue : MonoBehaviour
{
    public GameEvent onClick;
    public void OnClick(InputAction.CallbackContext context)
    {
        if (context.performed)
            onClick.Raise();
    }
}
