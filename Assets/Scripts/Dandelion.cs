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
    AudioSource audioSource;
    [SerializeField] private AudioClip upgradeSound;
    private bool running;

    private void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        running = false;
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
            if (upgraded == true && running == false)
            {
                enemy.DandelionSlow();
                StartCoroutine(Slow());
            }
        }

        yield return new WaitForSeconds(attackCooldown);
        isAttacking = false;
    }

    public void upgrade()
    {
        if (upgraded == false)
        {
            //Debug.Log("UpgradeWorked");
            audioSource.PlayOneShot(upgradeSound, 1F);
            //BUFFER TO ACTUAL UPGRADE PART
            damage = damage * upgradeMultiplier;
            attackCooldown = attackCooldown / upgradeMultiplier;
            speed = speed * upgradeMultiplier;
            leashRange = leashRange * upgradeMultiplier;
            gameObject.transform.localScale = Vector3.one * upgradeMultiplier;
            upgraded = true;
        }

    }

    IEnumerator Slow()
    {
        running = true;
        yield return new WaitForSecondsRealtime(3);
        running = false;
    }
}
