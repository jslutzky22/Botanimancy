using System;
using System.Collections;
using System.Collections.Generic;
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
        movementPoint10 = GameObject.FindGameObjectWithTag("movementPoint10");
        movementPoint11 = GameObject.FindGameObjectWithTag("movementPoint11");
        movementPoint12 = GameObject.FindGameObjectWithTag("movementPoint12");
        movementPoint13 = GameObject.FindGameObjectWithTag("movementPoint13");
        cameraForPlayerScript = GameObject.FindFirstObjectByType<Camera>().gameObject;
        playerScript = cameraForPlayerScript.GetComponent<PlayerScript>();
        enemySpawner = cameraForPlayerScript.GetComponent<EnemySpawner>();

        audioSource = GetComponent<AudioSource>();

        StartCoroutine(EnemyMovement());
    }

    IEnumerator EnemyMovement()
    {
        while (enemyHealth > 0 && movementProgress < 10)
        {
            if (movementPoint1.transform.position.x < transform.position.x)
            {
                while (transform.position.x > movementPoint1.transform.position.x && movementProgress == 0 && enemyHealth > 0)
                {
                    transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint1.transform.position)
                {
                    transform.position = movementPoint1.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint1.transform.position.x > transform.position.x)
            {
                while (transform.position.x < movementPoint1.transform.position.x && movementProgress == 0 && enemyHealth > 0)
                {
                    transform.position += new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint1.transform.position)
                {
                    transform.position = movementPoint1.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint1.transform.position.y > transform.position.y)
            {
                while (transform.position.y < movementPoint1.transform.position.y && movementProgress == 0 && enemyHealth > 0)
                {
                    transform.position += new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint1.transform.position)
                {
                    transform.position = movementPoint1.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint1.transform.position.y < transform.position.y)
            {
                while (transform.position.y > movementPoint1.transform.position.y && movementProgress == 0 && enemyHealth > 0)
                {
                    transform.position -= new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint1.transform.position)
                {
                    transform.position = movementPoint1.transform.position;
                }
                movementProgress++;
            }

            if (movementPoint2.transform.position.x < transform.position.x)
            {
                while (transform.position.x > movementPoint2.transform.position.x && movementProgress == 1 && enemyHealth > 0)
                {
                    transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint2.transform.position)
                {
                    transform.position = movementPoint2.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint2.transform.position.x > transform.position.x)
            {
                while (transform.position.x < movementPoint2.transform.position.x && movementProgress == 1 && enemyHealth > 0)
                {
                    transform.position += new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint2.transform.position)
                {
                    transform.position = movementPoint2.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint2.transform.position.y > transform.position.y)
            {
                while (transform.position.y < movementPoint2.transform.position.y && movementProgress == 1 && enemyHealth > 0)
                {
                    transform.position += new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint2.transform.position)
                {
                    transform.position = movementPoint2.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint2.transform.position.y < transform.position.y)
            {
                while (transform.position.y > movementPoint2.transform.position.y && movementProgress == 1 && enemyHealth > 0)
                {
                    transform.position -= new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint2.transform.position)
                {
                    transform.position = movementPoint2.transform.position;
                }
                movementProgress++;
            }

            if (movementPoint3.transform.position.x < transform.position.x)
            {
                while (transform.position.x > movementPoint3.transform.position.x && movementProgress == 2 && enemyHealth > 0)
                {
                    transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint3.transform.position)
                {
                    transform.position = movementPoint3.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint3.transform.position.x > transform.position.x)
            {
                while (transform.position.x < movementPoint3.transform.position.x && movementProgress == 2 && enemyHealth > 0)
                {
                    transform.position += new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint3.transform.position)
                {
                    transform.position = movementPoint3.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint3.transform.position.y > transform.position.y)
            {
                while (transform.position.y < movementPoint3.transform.position.y && movementProgress == 2 && enemyHealth > 0)
                {
                    transform.position += new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint3.transform.position)
                {
                    transform.position = movementPoint3.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint3.transform.position.y < transform.position.y)
            {
                while (transform.position.y > movementPoint3.transform.position.y && movementProgress == 2 && enemyHealth > 0)
                {
                    transform.position -= new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint3.transform.position)
                {
                    transform.position = movementPoint3.transform.position;
                }
                movementProgress++;
            }


            if (movementPoint4.transform.position.x < transform.position.x)
            {
                while (transform.position.x > movementPoint4.transform.position.x && movementProgress == 3 && enemyHealth > 0)
                {
                    transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint4.transform.position)
                {
                    transform.position = movementPoint4.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint4.transform.position.x > transform.position.x)
            {
                while (transform.position.x < movementPoint4.transform.position.x && movementProgress == 3 && enemyHealth > 0)
                {
                    transform.position += new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint4.transform.position)
                {
                    transform.position = movementPoint4.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint4.transform.position.y > transform.position.y)
            {
                while (transform.position.y < movementPoint4.transform.position.y && movementProgress == 3 && enemyHealth > 0)
                {
                    transform.position += new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint4.transform.position)
                {
                    transform.position = movementPoint4.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint4.transform.position.y < transform.position.y)
            {
                while (transform.position.y > movementPoint4.transform.position.y && movementProgress == 3 && enemyHealth > 0)
                {
                    transform.position -= new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint4.transform.position)
                {
                    transform.position = movementPoint4.transform.position;
                }
                movementProgress++;
            }

            if (movementPoint5.transform.position.x < transform.position.x)
            {
                while (transform.position.x > movementPoint5.transform.position.x && movementProgress == 4 && enemyHealth > 0)
                {
                    transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint5.transform.position)
                {
                    transform.position = movementPoint5.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint5.transform.position.x > transform.position.x)
            {
                while (transform.position.x < movementPoint5.transform.position.x && movementProgress == 4 && enemyHealth > 0)
                {
                    transform.position += new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint5.transform.position)
                {
                    transform.position = movementPoint5.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint5.transform.position.y > transform.position.y)
            {
                while (transform.position.y < movementPoint5.transform.position.y && movementProgress == 4 && enemyHealth > 0)
                {
                    transform.position += new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint5.transform.position)
                {
                    transform.position = movementPoint5.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint5.transform.position.y < transform.position.y)
            {
                while (transform.position.y > movementPoint5.transform.position.y && movementProgress == 4 && enemyHealth > 0)
                {
                    transform.position -= new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint5.transform.position)
                {
                    transform.position = movementPoint5.transform.position;
                }
                movementProgress++;
            }


            if (movementPoint6.transform.position.x < transform.position.x)
            {
                while (transform.position.x > movementPoint6.transform.position.x && movementProgress == 5 && enemyHealth > 0)
                {
                    transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint6.transform.position)
                {
                    transform.position = movementPoint6.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint6.transform.position.x > transform.position.x)
            {
                while (transform.position.x < movementPoint6.transform.position.x && movementProgress == 5 && enemyHealth > 0)
                {
                    transform.position += new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint6.transform.position)
                {
                    transform.position = movementPoint6.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint6.transform.position.y > transform.position.y)
            {
                while (transform.position.y < movementPoint6.transform.position.y && movementProgress == 5 && enemyHealth > 0)
                {
                    transform.position += new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint6.transform.position)
                {
                    transform.position = movementPoint6.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint6.transform.position.y < transform.position.y)
            {
                while (transform.position.y > movementPoint6.transform.position.y && movementProgress == 5 && enemyHealth > 0)
                {
                    transform.position -= new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint6.transform.position)
                {
                    transform.position = movementPoint6.transform.position;
                }
                movementProgress++;
            }


            if (movementPoint7.transform.position.x < transform.position.x)
            {
                while (transform.position.x > movementPoint7.transform.position.x && movementProgress == 6 && enemyHealth > 0)
                {
                    transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint7.transform.position)
                {
                    transform.position = movementPoint7.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint7.transform.position.x > transform.position.x)
            {
                while (transform.position.x < movementPoint7.transform.position.x && movementProgress == 6 && enemyHealth > 0)
                {
                    transform.position += new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint7.transform.position)
                {
                    transform.position = movementPoint7.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint7.transform.position.y > transform.position.y)
            {
                while (transform.position.y < movementPoint7.transform.position.y && movementProgress == 6 && enemyHealth > 0)
                {
                    transform.position += new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint7.transform.position)
                {
                    transform.position = movementPoint7.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint7.transform.position.y < transform.position.y)
            {
                while (transform.position.y > movementPoint7.transform.position.y && movementProgress == 6 && enemyHealth > 0)
                {
                    transform.position -= new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint7.transform.position)
                {
                    transform.position = movementPoint7.transform.position;
                }
                movementProgress++;
            }


            if (movementPoint8.transform.position.x < transform.position.x)
            {
                while (transform.position.x > movementPoint8.transform.position.x && movementProgress == 7 && enemyHealth > 0)
                {
                    transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint8.transform.position)
                {
                    transform.position = movementPoint8.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint8.transform.position.x > transform.position.x)
            {
                while (transform.position.x < movementPoint8.transform.position.x && movementProgress == 7 && enemyHealth > 0)
                {
                    transform.position += new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint8.transform.position)
                {
                    transform.position = movementPoint8.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint8.transform.position.y > transform.position.y)
            {
                while (transform.position.y < movementPoint8.transform.position.y && movementProgress == 7 && enemyHealth > 0)
                {
                    transform.position += new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint8.transform.position)
                {
                    transform.position = movementPoint8.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint8.transform.position.y < transform.position.y)
            {
                while (transform.position.y > movementPoint8.transform.position.y && movementProgress == 7 && enemyHealth > 0)
                {
                    transform.position -= new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint8.transform.position)
                {
                    transform.position = movementPoint8.transform.position;
                }
                movementProgress++;
            }


            if (movementPoint9.transform.position.x < transform.position.x)
            {
                while (transform.position.x > movementPoint9.transform.position.x && movementProgress == 8 && enemyHealth > 0)
                {
                    transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint9.transform.position)
                {
                    transform.position = movementPoint9.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint9.transform.position.x > transform.position.x)
            {
                while (transform.position.x < movementPoint9.transform.position.x && movementProgress == 8 && enemyHealth > 0)
                {
                    transform.position += new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint9.transform.position)
                {
                    transform.position = movementPoint9.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint9.transform.position.y > transform.position.y)
            {
                while (transform.position.y < movementPoint9.transform.position.y && movementProgress == 8 && enemyHealth > 0)
                {
                    transform.position += new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint9.transform.position)
                {
                    transform.position = movementPoint9.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint9.transform.position.y < transform.position.y)
            {
                while (transform.position.y > movementPoint9.transform.position.y && movementProgress == 8 && enemyHealth > 0)
                {
                    transform.position -= new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint9.transform.position)
                {
                    transform.position = movementPoint9.transform.position;
                }
                movementProgress++;
            }


            if (movementPoint10.transform.position.x < transform.position.x)
            {
                while (transform.position.x > movementPoint10.transform.position.x && movementProgress == 9 && enemyHealth > 0)
                {
                    transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint10.transform.position)
                {
                    transform.position = movementPoint10.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint10.transform.position.x > transform.position.x)
            {
                while (transform.position.x < movementPoint10.transform.position.x && movementProgress == 9 && enemyHealth > 0)
                {
                    transform.position += new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint10.transform.position)
                {
                    transform.position = movementPoint10.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint10.transform.position.y > transform.position.y)
            {
                while (transform.position.y < movementPoint10.transform.position.y && movementProgress == 9 && enemyHealth > 0)
                {
                    transform.position += new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint10.transform.position)
                {
                    transform.position = movementPoint10.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint10.transform.position.y < transform.position.y)
            {
                while (transform.position.y > movementPoint10.transform.position.y && movementProgress == 9 && enemyHealth > 0)
                {
                    transform.position -= new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint10.transform.position)
                {
                    transform.position = movementPoint10.transform.position;
                }
                movementProgress++;
            }


            if (movementPoint11.transform.position.x < transform.position.x)
            {
                while (transform.position.x > movementPoint11.transform.position.x && movementProgress == 10 && enemyHealth > 0)
                {
                    transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint11.transform.position)
                {
                    transform.position = movementPoint11.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint11.transform.position.x > transform.position.x)
            {
                while (transform.position.x < movementPoint11.transform.position.x && movementProgress == 10 && enemyHealth > 0)
                {
                    transform.position += new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint11.transform.position)
                {
                    transform.position = movementPoint11.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint11.transform.position.y > transform.position.y)
            {
                while (transform.position.y < movementPoint11.transform.position.y && movementProgress == 10 && enemyHealth > 0)
                {
                    transform.position += new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint11.transform.position)
                {
                    transform.position = movementPoint11.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint11.transform.position.y < transform.position.y)
            {
                while (transform.position.y > movementPoint11.transform.position.y && movementProgress == 10 && enemyHealth > 0)
                {
                    transform.position -= new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint11.transform.position)
                {
                    transform.position = movementPoint11.transform.position;
                }
                movementProgress++;
            }


            if (movementPoint12.transform.position.x < transform.position.x)
            {
                while (transform.position.x > movementPoint12.transform.position.x && movementProgress == 11 && enemyHealth > 0)
                {
                    transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint12.transform.position)
                {
                    transform.position = movementPoint12.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint12.transform.position.x > transform.position.x)
            {
                while (transform.position.x < movementPoint12.transform.position.x && movementProgress == 11 && enemyHealth > 0)
                {
                    transform.position += new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint12.transform.position)
                {
                    transform.position = movementPoint12.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint12.transform.position.y > transform.position.y)
            {
                while (transform.position.y < movementPoint12.transform.position.y && movementProgress == 11 && enemyHealth > 0)
                {
                    transform.position += new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint12.transform.position)
                {
                    transform.position = movementPoint12.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint12.transform.position.y < transform.position.y)
            {
                while (transform.position.y > movementPoint12.transform.position.y && movementProgress == 11 && enemyHealth > 0)
                {
                    transform.position -= new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint12.transform.position)
                {
                    transform.position = movementPoint12.transform.position;
                }
                movementProgress++;
            }


            if (movementPoint13.transform.position.x < transform.position.x)
            {
                while (transform.position.x > movementPoint13.transform.position.x && movementProgress == 12 && enemyHealth > 0)
                {
                    transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint13.transform.position)
                {
                    transform.position = movementPoint13.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint13.transform.position.x > transform.position.x)
            {
                while (transform.position.x < movementPoint13.transform.position.x && movementProgress == 12 && enemyHealth > 0)
                {
                    transform.position += new Vector3((enemySpeed / 100), 0, 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint13.transform.position)
                {
                    transform.position = movementPoint13.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint13.transform.position.y > transform.position.y)
            {
                while (transform.position.y < movementPoint13.transform.position.y && movementProgress == 12 && enemyHealth > 0)
                {
                    transform.position += new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint13.transform.position)
                {
                    transform.position = movementPoint13.transform.position;
                }
                movementProgress++;
            }
            else if (movementPoint13.transform.position.y < transform.position.y)
            {
                while (transform.position.y > movementPoint13.transform.position.y && movementProgress == 12 && enemyHealth > 0)
                {
                    transform.position -= new Vector3(0, (enemySpeed / 100), 0);
                    yield return new WaitForSecondsRealtime(0.01f);
                }
                if (transform.position != movementPoint13.transform.position)
                {
                    transform.position = movementPoint13.transform.position;
                }
                movementProgress++;
            }


            // Final check: if movement is done, damage the player and destroy the enemy
            if (movementProgress >= 13 && enemyHealth > 0)
            {
                // Subtract 1 HP from player
                PlayerHealth.Instance.PlayerTakeDamage(1); // or whatever method you use

                enemySpawner.enemiesAlive--;

                // Destroy the enemy
                Destroy(this.gameObject);
            }
        }
    }
    
    public void TakeDamage(int amount)
    {
        enemyHealth -= amount;
        audioSource.PlayOneShot(damaged, 1F);
        if (enemyHealth <= 0)
        {
            playerScript.plantFood++;
            enemySpawner.enemiesAlive--;
            Destroy(this.gameObject);
        }
    }

}