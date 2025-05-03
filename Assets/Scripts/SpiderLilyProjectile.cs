using UnityEngine;

public class SpiderLilyProjectile : MonoBehaviour
{
    private int damage;
    private float slowDuration;
    private float slowAmount;
    public SpiderLily owner;

    public void SetSlowEffect(int _damage, float _duration, float _amount)
    {
        damage = _damage;
        slowDuration = _duration;
        slowAmount = _amount;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            EnemyController ec = collision.GetComponent<EnemyController>();
            if (ec != null)
            {
                bool willDie = ec.enemyHealth <= damage;
                ec.TakeDamage(damage);

                if (willDie && owner != null && owner.upgraded)
                {
                    owner.SpawnMiniSpiders(transform.position);
                }

                ec.StartCoroutine(ec.ApplySlow(slowAmount, slowDuration));
            }

            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Destroy(gameObject, 5f); // safety delete
    }
}
