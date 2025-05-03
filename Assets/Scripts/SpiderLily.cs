using System.Collections;
using UnityEngine;

public class SpiderLily : BaseCreature
{
    public GameObject projectilePrefab;
    public Transform shootPoint;

    [Header("Combat Stats")]
    public int meleeDamage = 10;
    public int rangedDamage = 5;
    public float bulletSpeed = 5f;
    public float distanceToShoot = 5f;
    public float shotDelay = 1.5f;

    [Header("Slow Effect")]
    public float slowDuration = 2f;
    public float slowAmount = 0.5f;

    [Header("Upgrade")]
    public bool upgraded = false;

    [Header("Mini Spider Spawn")]
    public GameObject miniSpiderPrefab;
    [SerializeField] private int miniSpiderCount = 3;
    public float miniSpiderLifetime = 5f;


    private GameObject closestEnemy;

    private void Start()
    {
        StartCoroutine(ShootLoop());
    }

    private IEnumerator ShootLoop()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(shotDelay);
        }
    }

    private void Shoot()
    {
        FindClosestEnemy();

        if (closestEnemy == null)
            return;

        float distance = Vector2.Distance(transform.position, closestEnemy.transform.position);

        if (distance <= attackRange)
            return;

        if (distance > distanceToShoot)
            return;

        FireProjectile(shootPoint);
    }

    private void FireProjectile(Transform point)
    {
        if (projectilePrefab == null || point == null)
            return;

        GameObject bullet = Instantiate(projectilePrefab, point.position, Quaternion.identity);
        Vector2 direction = (closestEnemy.transform.position - point.position).normalized;

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = direction * bulletSpeed;
        }

        SpiderLilyProjectile slp = bullet.GetComponent<SpiderLilyProjectile>();
        if (slp != null)
        {
            slp.SetSlowEffect(rangedDamage, slowDuration, slowAmount);
            slp.owner = this;
        }
    }

    private void FindClosestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float closestDistance = Mathf.Infinity;
        closestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector2.Distance(transform.position, enemy.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestEnemy = enemy;
            }
        }
    }

    public void upgrade()
    {
        if (!upgraded)
        {
            transform.localScale = Vector3.one * 2;
            upgraded = true;
        }
    }
    public void SpawnMiniSpiders(Vector3 position)
    {
        for (int i = 0; i < miniSpiderCount; i++)
        {
            Vector3 offset = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), 0f);
            GameObject spider = Instantiate(miniSpiderPrefab, position + offset, Quaternion.identity);
            Destroy(spider, miniSpiderLifetime);
        }
    }


    protected override IEnumerator Attack(GameObject target)
    {
        isAttacking = true;

        if (target != null)
        {
            EnemyController ec = target.GetComponent<EnemyController>();
            if (ec != null)
            {
                bool willDie = ec.enemyHealth <= meleeDamage;
                ec.TakeDamage(meleeDamage);

                if (willDie && upgraded)
                {
                    SpawnMiniSpiders(target.transform.position);
                }
            }
        }

        yield return new WaitForSeconds(1f); // Cooldown before another attack
        isAttacking = false;
    }
}
