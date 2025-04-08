using System.Collections;
using UnityEngine;

public class Wolfsbane : BaseCreature
{
    public int damage = 25;
    public float attackCooldown = 1f;
    Animator m_Animator;

    private void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }
    protected override IEnumerator Attack(GameObject target)
    {
        isAttacking = true;

        // Replace with animation or visual feedback
        //Debug.Log($"{gameObject.name} attacks {target.name} for {damage} damage!");

        EnemyController enemy = target.GetComponent<EnemyController>();
        if (enemy != null)
        {
            m_Animator.SetTrigger("attack");
            enemy.TakeDamage(damage);
        }

        yield return new WaitForSeconds(attackCooldown);
        isAttacking = false;
    }
}
