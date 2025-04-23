using UnityEngine;

public class SpiderLilyProjectile : MonoBehaviour
{
    private Transform target;
    private float speed;
    private int damage;
    private float slowDuration;
    private float slowAmount;

    public void Init(Transform _target, float _speed, int _damage, float _slowDuration, float _slowAmount)
    {
        target = _target;
        speed = _speed;
        damage = _damage;
        slowDuration = _slowDuration;
        slowAmount = _slowAmount;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            EnemyController ec = target.GetComponent<EnemyController>();
            if (ec != null)
            {
                ec.TakeDamage(damage);
                ec.StartCoroutine(ec.ApplySlow(slowAmount, slowDuration));
            }

            Destroy(gameObject);
        }
    }
}
