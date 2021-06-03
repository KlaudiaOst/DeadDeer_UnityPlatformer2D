using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 2;

    public float attackRate = 2f;
    float nextAttackTime = 0f;

    private void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
        
        
    }

    public void Attack()
    {
        animator.SetTrigger("attack");

        //deteck enemies
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        //damage enemy
        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("Ciach" + enemy.name);
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            
        }

    }

    private void OnDrawGizmosSelected()
    {
        //if not used
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
