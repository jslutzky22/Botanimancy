using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class EnemyController : MonoBehaviour
{
    public int enemyHealth;
    public float enemySpeed;
    private int movementProgress = 0;
    public PlayerScript playerScript;
    public EnemySpawner enemySpawner;
    private GameObject cameraForPlayerScript;

    private GameObject movementPoint1;
    private GameObject movementPoint2;
    private GameObject movementPoint3;
    private GameObject movementPoint4;
    private GameObject movementPoint5;
    private GameObject movementPoint6;
    private GameObject movementPoint7;
    private GameObject movementPoint8;
    private GameObject movementPoint9;
    private GameObject movementPoint10;
    private GameObject movementPoint11;
    private GameObject movementPoint12;
    private GameObject movementPoint13;
    private GameObject movementPoint14;
    private GameObject movementPoint15;
    private GameObject movementPoint16;

    AudioSource audioSource;
    [SerializeField] private AudioClip damaged;
    private bool isDead = false;
    Animator m_Animator;

    void Awake()
    {
        if (GameObject.FindGameObjectWithTag("movementPoint1") != null)
        {
            movementPoint1 = GameObject.FindGameObjectWithTag("movementPoint1");
        }
        if (GameObject.FindGameObjectWithTag("movementPoint2") != null)
        {
            movementPoint2 = GameObject.FindGameObjectWithTag("movementPoint2");
        }
        if (GameObject.FindGameObjectWithTag("movementPoint3") != null)
        {
            movementPoint3 = GameObject.FindGameObjectWithTag("movementPoint3");
        }
        if (GameObject.FindGameObjectWithTag("movementPoint4") != null)
        {
            movementPoint4 = GameObject.FindGameObjectWithTag("movementPoint4");
        }
        if (GameObject.FindGameObjectWithTag("movementPoint5") != null)
        {
            movementPoint5 = GameObject.FindGameObjectWithTag("movementPoint5");
        }
        if (GameObject.FindGameObjectWithTag("movementPoint6") != null)
        {
            movementPoint6 = GameObject.FindGameObjectWithTag("movementPoint6");
        }
        if (GameObject.FindGameObjectWithTag("movementPoint7") != null)
        {
            movementPoint7 = GameObject.FindGameObjectWithTag("movementPoint7");
        }
        if (GameObject.FindGameObjectWithTag("movementPoint8") != null)
        {
            movementPoint8 = GameObject.FindGameObjectWithTag("movementPoint8");
        }
        if (GameObject.FindGameObjectWithTag("movementPoint9") != null)
        {
            movementPoint9 = GameObject.FindGameObjectWithTag("movementPoint9");
        }
        if (GameObject.FindGameObjectWithTag("movementPoint10") != null)
        {
            movementPoint10 = GameObject.FindGameObjectWithTag("movementPoint10");
        }
        if (GameObject.FindGameObjectWithTag("movementPoint11") != null)
        {
            movementPoint11 = GameObject.FindGameObjectWithTag("movementPoint11");
        }
        if (GameObject.FindGameObjectWithTag("movementPoint12") != null)
        {
            movementPoint12 = GameObject.FindGameObjectWithTag("movementPoint12");
        }
        if (GameObject.FindGameObjectWithTag("movementPoint13") != null)
        {
            movementPoint13 = GameObject.FindGameObjectWithTag("movementPoint13");
        }
        if (GameObject.FindGameObjectWithTag("movementPoint14") != null)
        {
            movementPoint14 = GameObject.FindGameObjectWithTag("movementPoint14");
        }
        if (GameObject.FindGameObjectWithTag("movementPoint15") != null)
        {
            movementPoint15 = GameObject.FindGameObjectWithTag("movementPoint15");
        }
        if (GameObject.FindGameObjectWithTag("movementPoint16") != null)
        {
            movementPoint16 = GameObject.FindGameObjectWithTag("movementPoint16");
        }
        cameraForPlayerScript = GameObject.FindFirstObjectByType<Camera>().gameObject;
        playerScript = cameraForPlayerScript.GetComponent<PlayerScript>();
        enemySpawner = cameraForPlayerScript.GetComponent<EnemySpawner>();

        audioSource = GetComponent<AudioSource>();

        StartCoroutine(EnemyMovement());
    }
    private void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    IEnumerator EnemyMovement()
    {
        while (enemyHealth > 0)
        {
            if (isDead) yield break;
            if (movementPoint1 != null)
            {
                while (transform.position != movementPoint1.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint1.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            if (isDead) yield break;
            if (movementPoint2 != null)
            {
                while (transform.position != movementPoint2.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint2.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            if (isDead) yield break;
            if (movementPoint3 != null)
            {
                while (transform.position != movementPoint3.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint3.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            if (isDead) yield break;
            if (movementPoint4 != null)
            {
                while (transform.position != movementPoint4.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint4.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            if (isDead) yield break;
            if (movementPoint5 != null)
            {
                while (transform.position != movementPoint5.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint5.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            if (isDead) yield break;
            if (movementPoint6 != null)
            {
                while (transform.position != movementPoint6.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint6.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            if (isDead) yield break;
            if (movementPoint7 != null)
            {
                while (transform.position != movementPoint7.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint7.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            if (isDead) yield break;
            if (movementPoint8 != null)
            {
                while (transform.position != movementPoint8.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint8.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            if (isDead) yield break;
            if (movementPoint9 != null)
            {
                while (transform.position != movementPoint9.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint9.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            if (isDead) yield break;
            if (movementPoint10 != null)
            {
                while (transform.position != movementPoint10.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint10.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            if (isDead) yield break;
            if (movementPoint11 != null)
            {
                while (transform.position != movementPoint11.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint11.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            if (isDead) yield break;
            if (movementPoint12 != null)
            {
                while (transform.position != movementPoint12.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint12.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            if (isDead) yield break;
            if (movementPoint13 != null)
            {
                while (transform.position != movementPoint13.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint13.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            if (isDead) yield break;
            if (movementPoint14 != null)
            {
                while (transform.position != movementPoint14.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint14.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            if (isDead) yield break;
            if (movementPoint15 != null)
            {
                while (transform.position != movementPoint15.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint15.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            if (isDead) yield break;
            if (movementPoint16 != null)
            {
                while (transform.position != movementPoint16.transform.position)
                {
                    transform.position = Vector3.MoveTowards(transform.position, movementPoint16.transform.position, enemySpeed / 100);
                    movementProgress++;
                    yield return new WaitForSecondsRealtime(0.01f);
                }
            }

            // Final check: if movement is done, damage the player and destroy the enemy
            if (enemyHealth > 0)
            {
                // Subtract 1 HP from player
                PlayerHealth.Instance.PlayerTakeDamage(1); // or whatever method you use

                enemySpawner.enemiesAlive--;

                // Destroy the enemy
                //Debug.Log("EnemyKilledDead");
                Destroy(this.gameObject);
            }


        }
    }

    public IEnumerator ApplySlow(float slowAmount, float duration)
    {
        float originalSpeed = enemySpeed;
        enemySpeed *= slowAmount;

        yield return new WaitForSeconds(duration);

        enemySpeed = originalSpeed;
    }

    public void TakeDamage(int amount)
    {
        enemyHealth -= amount;
        
        
        //StartCoroutine(HandleDeath());
        audioSource.PlayOneShot(damaged, 0.5F);
        if (enemyHealth <= 0 && isDead == false)
        {
            isDead = true;
            StopAllCoroutines();
            playerScript.plantFood++;
            enemySpawner.enemiesAlive--;
            Debug.Log("DestroyEnemy");
            m_Animator.SetBool("Dead", true);
            gameObject.tag = ("Dead");
            //Destroy(this.gameObject);
        }
    }

    public void perish()
    {
        Debug.Log("Perished");
        Destroy(this.gameObject);
    }

}