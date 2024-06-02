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
        animator.SetBool("isAttackFront", Input.GetKey(KeyCode.F));
        animator.SetBool("isAttackBack", Input.GetKey(KeyCode.C));
        animator.SetBool("isAttackOverhead", Input.GetKey(KeyCode.R));
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
