using System.Collections;
using UnityEngine;

public class SpiderLily : BaseCreature
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 5f;
    public float slowDuration = 2f;
    public float slowAmount = 0.5f;
    public int meleeDamage = 10;
    public int rangedDamage = 5;
    public float attackCooldown = 1.5f;

    protected override IEnumerator Attack(GameObject target)
    {
        isAttacking = true;

        if (Vector3.Distance(transform.position, target.transform.position) <= attackRange)
        {
            // Melee Attack
            EnemyController ec = target.GetComponent<EnemyController>();
            if (ec != null)
            {
                ec.TakeDamage(meleeDamage);
            }
        }
        else
        {
            // Ranged Attack
            GameObject proj = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            SpiderLilyProjectile p = proj.GetComponent<SpiderLilyProjectile>();
            if (p != null)
            {
                p.Init(target.transform, projectileSpeed, rangedDamage, slowDuration, slowAmount);
            }
        }

        yield return new WaitForSeconds(attackCooldown);
        isAttacking = false;
    }
}
