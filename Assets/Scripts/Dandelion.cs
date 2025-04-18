using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dandelion : BaseCreature
{
    public int damage = 25;
    public float attackCooldown = 1f;
    public int upgradeMultiplier = 2;
    public bool upgraded = false;
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

    public void upgrade()
    {
        if (upgraded == false)
        {
            Debug.Log("UpgradeWorked");
            damage = damage * upgradeMultiplier;
            attackCooldown = attackCooldown / upgradeMultiplier;
            speed = speed * upgradeMultiplier;
            leashRange = leashRange * upgradeMultiplier;
            gameObject.transform.localScale = Vector3.one * upgradeMultiplier;
            upgraded = true;
        }

    }
}
