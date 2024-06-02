using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    [SerializeField] private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Determine Attack from input
        animator.SetBool("AttackFront", Input.GetKey(KeyCode.F));
        animator.SetBool("AttackBack", Input.GetKey(KeyCode.C));
        animator.SetBool("AttackOverhead", Input.GetKey(KeyCode.R));
    }

    void AttackFront()
    {
    }

    void AttackBack()
    {
    }

    void AttackOverhead()
    {
    }

}
