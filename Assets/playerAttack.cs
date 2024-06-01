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
        if (Input.GetKeyDown(KeyCode.F))
        {
            AttackFront();
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            AttackBack();
        }
        else if (!Input.GetKeyDown(KeyCode.R))
        {
            AttackOverhead();
        }
    }

    void AttackFront()
    {
        animator.SetBool("isAttackFront", true);
    }

    void AttackBack()
    {
        animator.SetBool("isAttackBack", true);

    }

    void AttackOverhead()
    {
        animator.SetBool("isAttackOverhead", true);
    }


}
