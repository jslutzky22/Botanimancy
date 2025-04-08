using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int enemyHealth;
    public float enemySpeed;
    private int movementProgress = 0;

    private GameObject movementPoint1;
    private GameObject movementPoint2;
    private GameObject movementPoint3;
    private GameObject movementPoint4;
    private GameObject movementPoint5;
    private GameObject movementPoint6;
    private GameObject movementPoint7;
    private GameObject movementPoint8;
    private GameObject movementPoint9;

    AudioSource audioSource;
    [SerializeField] private AudioClip damaged;

    void Awake()
    {
        movementPoint1 = GameObject.FindGameObjectWithTag("movementPoint1");
        movementPoint2 = GameObject.FindGameObjectWithTag("movementPoint2");
        movementPoint3 = GameObject.FindGameObjectWithTag("movementPoint3");
        movementPoint4 = GameObject.FindGameObjectWithTag("movementPoint4");
        movementPoint5 = GameObject.FindGameObjectWithTag("movementPoint5");
        movementPoint6 = GameObject.FindGameObjectWithTag("movementPoint6");
        movementPoint7 = GameObject.FindGameObjectWithTag("movementPoint7");
        movementPoint8 = GameObject.FindGameObjectWithTag("movementPoint8");
        movementPoint9 = GameObject.FindGameObjectWithTag("movementPoint9");

        audioSource = GetComponent<AudioSource>();

        StartCoroutine(EnemyMovement());
    }

    IEnumerator EnemyMovement()
    {
        while (enemyHealth > 0 && movementProgress < 10)
        {
            while (transform.position != movementPoint1.transform.position && movementProgress == 0 && enemyHealth > 0)
            {
                transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                yield return new WaitForSecondsRealtime(0.01f);
            }
            movementProgress++;


            while (transform.position != movementPoint1.transform.position && movementProgress == 1 && enemyHealth > 0)
            {
                transform.position += new Vector3(0, (enemySpeed / 100), 0);
                yield return new WaitForSecondsRealtime(0.01f);
            }

            if (transform.position.y != 1.5 && movementProgress == 1)
            {
                transform.position = new Vector3(transform.position.x, 1.5f);
            }
            movementProgress++;


            while (transform.position.x > 2.5 && movementProgress == 2 && enemyHealth > 0)
            {
                transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                yield return new WaitForSecondsRealtime(0.01f);
            }

            if (transform.position.x != 2.5 && movementProgress == 2)
            {
                transform.position = new Vector3(2.5f, transform.position.y);
            }
            movementProgress++;


            while (transform.position.y > -1.5 && movementProgress == 3 && enemyHealth > 0)
            {
                transform.position -= new Vector3(0, (enemySpeed / 100), 0);
                yield return new WaitForSecondsRealtime(0.01f);
            }

            if (transform.position.y != -1.5 && movementProgress == 3)
            {
                transform.position = new Vector3(transform.position.x, -1.5f);
            }
            movementProgress++;


            while (transform.position.x > -2.5 && movementProgress == 4 && enemyHealth > 0)
            {
                transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                yield return new WaitForSecondsRealtime(0.01f);
            }

            if (transform.position.x != -2.5 && movementProgress == 4)
            {
                transform.position = new Vector3(-2.5f, transform.position.y);
            }
            movementProgress++;


            while (transform.position.y < 1.5 && movementProgress == 5 && enemyHealth > 0)
            {
                transform.position += new Vector3(0, (enemySpeed / 100), 0);
                yield return new WaitForSecondsRealtime(0.01f);
            }

            if (transform.position.y != 1.5 && movementProgress == 5)
            {
                transform.position = new Vector3(transform.position.x, 1.5f);
            }
            movementProgress++;


            while (transform.position.x > -6.5 && movementProgress == 6 && enemyHealth > 0)
            {
                transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                yield return new WaitForSecondsRealtime(0.01f);
            }

            if (transform.position.x != -6.5 && movementProgress == 6)
            {
                transform.position = new Vector3(-6.5f, transform.position.y);
            }
            movementProgress++;


            while (transform.position.y > -1.5 && movementProgress == 7 && enemyHealth > 0)
            {
                transform.position -= new Vector3(0, (enemySpeed / 100), 0);
                yield return new WaitForSecondsRealtime(0.01f);
            }

            if (transform.position.y != -1.5 && movementProgress == 7)
            {
                transform.position = new Vector3(transform.position.x, -1.5f);
            }
            movementProgress++;


            while (transform.position.x > -9.5 && movementProgress == 8 && enemyHealth > 0)
            {
                transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                yield return new WaitForSecondsRealtime(0.01f);
            }

            if (transform.position.x != -9.5 && movementProgress == 8)
            {
                transform.position = new Vector3(-9.5f, transform.position.y);
            }
            movementProgress++;
        }
    }
    
    public void TakeDamage(int amount)
    {
        enemyHealth -= amount;
        audioSource.PlayOneShot(damaged, 1F);
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

}