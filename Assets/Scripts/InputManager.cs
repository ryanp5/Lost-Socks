using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3Variable mousePos;
    private Camera mainCam;
    void Start()
    {
       mainCam = Camera.main;
    }
    
    private void FixedUpdate()
    {
        var mouse = Mouse.current;
        mousePos.value = mainCam.ScreenToWorldPoint(mouse.position.ReadValue());
    }
    private void Update()
    {
       
    }


}
