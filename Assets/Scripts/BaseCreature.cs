using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCreature : MonoBehaviour
{
    [Header("Creature Stats")]
    public int health = 100;
    public float speed = 1f;
    public float leashRange = 2f;
    public float attackRange = 1f;

    protected Vector3 leashPoint;
    public bool isPlaced = false;
    protected bool isAttacking = false;

    protected virtual void Update()
    {
        if (!isPlaced) return;

        GameObject target = FindClosestEnemy();
        if (target != null && Vector3.Distance(leashPoint, target.transform.position) <= leashRange)
        {
            MoveToTarget(target);
            if (Vector3.Distance(transform.position, target.transform.position) <= attackRange)
            {
                if (!isAttacking)
                    StartCoroutine(Attack(target));
            }
        }
        else
        {
            ReturnToLeashPoint();
        }
    }

    public void Place(Vector3 position)
    {
        leashPoint = position;
        transform.position = position;
        isPlaced = true;


    }

    protected virtual void MoveToTarget(GameObject target)
    {
        Vector3 direction = (target.transform.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }

    protected void ReturnToLeashPoint()
    {
        if (Vector3.Distance(transform.position, leashPoint) > 0.1f)
        {
            Vector3 direction = (leashPoint - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    protected abstract IEnumerator Attack(GameObject target);

    protected GameObject FindClosestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject closest = null;
        float minDist = Mathf.Infinity;

        foreach (GameObject enemy in enemies)
        {
            float dist = Vector3.Distance(leashPoint, enemy.transform.position);
            if (dist < minDist)
            {
                minDist = dist;
                closest = enemy;
            }
        }

        return closest;
    }

    protected virtual void OnDrawGizmosSelected()
    {
        // Use the current position if not placed yet
        Vector3 center = isPlaced ? leashPoint : transform.position;

        // Leash Range (Blue)
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(center, leashRange);

        // Attack Range (Red)
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);

        // Optional: Draw line to leash point
        if (isPlaced)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(transform.position, leashPoint);
        }
    }

}
