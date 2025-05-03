using UnityEngine;

public class MiniSpider : MonoBehaviour
{
    public float speed = 2f;
    public int damage = 3;
    private GameObject target;

    private void Update()
    {
        if (target == null) FindTarget();

        if (target != null)
        {
            Vector2 dir = (target.transform.position - transform.position).normalized;
            transform.Translate(dir * speed * Time.deltaTime);
        }
    }

    private void FindTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float closest = float.MaxValue;

        foreach (GameObject e in enemies)
        {
            float dist = Vector2.Distance(transform.position, e.transform.position);
            if (dist < closest)
            {
                closest = dist;
                target = e;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            EnemyController ec = collision.GetComponent<EnemyController>();
            if (ec != null)
            {
                ec.TakeDamage(damage);
            }

            Destroy(gameObject); // Suicide after attack
        }
    }
}
