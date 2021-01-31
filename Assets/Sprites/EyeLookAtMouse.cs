using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeLookAtMouse : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3Variable mousePos;
    public Transform[] eyes;
    public Vector2 eyeDirection;
    void Start()
    {
        eyes = GetComponentsInChildren<Transform>();
    }

    private void FixedUpdate()
    {
        eyeDirection = (eyes[2].position - mousePos.value).normalized;
        Vector3 pos = ((eyes[2].position - eyes[0].position)- new Vector3(eyeDirection.x,eyeDirection.y,0));
        pos = Vector3.ClampMagnitude(pos, 0.2f) + eyes[0].position;
        eyes[2].position = pos;
    }
}
