using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimatorValue : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void setAnimatorBoolFal(string name)
    {
        animator.SetBool(name, false);
    }
    public void setAnimatorBoolTru(string name)
    {
        animator.SetBool(name, true);
    }
}
