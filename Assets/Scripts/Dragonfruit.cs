using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragonfruit : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletPos;
    [SerializeField] private Transform bulletPos2;
    [SerializeField] private Transform bulletPos3;
    [SerializeField] private float bulletSpeed;
    private GameObject closestEnemy;
    [SerializeField] private float distanceToShoot;
    //[SerializeField] private AudioClip blastNoise;
    public bool upgraded;
    [SerializeField] private AudioClip upgradeSound;
    Animator m_Animator;
    AudioSource audioSource;
    public float upgradeMultiplier;
    public float shotDelay;
    public float upgradedShotDelay;
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(ShootLoop());
    }




    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator ShootLoop()
    {
        while (true)
        {
            shoot();
            yield return new WaitForSeconds(shotDelay);
        }
    }

    void FindClosestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float closestDistance = Mathf.Infinity;
        closestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector2.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < closestDistance)
            {
                closestDistance = distanceToEnemy;
                closestEnemy = enemy;
            }
        }

    }
    void shoot()
    {
        FindClosestEnemy();
        if (closestEnemy != null)
        {
            float distance = Vector2.Distance(transform.position, closestEnemy.transform.position);
            if (distance < distanceToShoot)
            {
                GameObject firedBullet = Instantiate(bullet, bulletPos.position, Quaternion.identity);


                Vector2 direction = (closestEnemy.transform.position - bulletPos.position).normalized;


                firedBullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
            }
            if (upgraded == true)
            {
                Debug.Log("UpgradeShoot!");
                if (distance < distanceToShoot)
                {
                    GameObject firedBullet = Instantiate(bullet, bulletPos2.position, Quaternion.identity);


                    Vector2 direction = (closestEnemy.transform.position - bulletPos2.position).normalized;


                    firedBullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
                }
                if (distance < distanceToShoot)
                {
                    GameObject firedBullet = Instantiate(bullet, bulletPos3.position, Quaternion.identity);


                    Vector2 direction = (closestEnemy.transform.position - bulletPos3.position).normalized;


                    firedBullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
                }
            }
        }
        
        //AudioSource.PlayClipAtPoint(blastNoise, transform.position);

    }
    public void upgrade()
    {
        if (upgraded == false)
        {
            //Debug.Log("UpgradeWorked");
            audioSource.PlayOneShot(upgradeSound, 1F);
            //BUFFER TO ACTUAL UPGRADE PART
            gameObject.transform.localScale = Vector3.one * upgradeMultiplier;
            shotDelay = upgradedShotDelay;
            bulletSpeed = upgradeMultiplier * 10;
            upgraded = true;
        }

    }
    void Destroy()
    {
        Destroy(gameObject);
    }
}
