using System.Collections;
using UnityEngine;

public class Wolfsbane : BaseCreature
{
    public int damage = 25;
    public float attackCooldown = 1f;

    protected override IEnumerator Attack(GameObject target)
    {
        isAttacking = true;

        // Replace with animation or visual feedback
        Debug.Log($"{gameObject.name} attacks {target.name} for {damage} damage!");

        EnemyController enemy = target.GetComponent<EnemyController>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        yield return new WaitForSeconds(attackCooldown);
        isAttacking = false;
    }
}
