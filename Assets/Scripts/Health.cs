using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public int health = 3;
    private bool isDead = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            TakeDamage(1);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Dead();
        }
    }

    public void TakeDamage(int damage)
    {
        if (health > damage)
        {
            health = health - damage;
            animator.SetTrigger("hurt");
        }
        else
        {
            Dead();
        }
    }

    public void Dead()
    {
        isDead = true;
        animator.SetBool("isDead", isDead);
    }

}
