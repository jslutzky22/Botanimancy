using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int enemyHealth;
    public float enemySpeed;
    private int movementProgress = 0;

    private List<GameObject> movementPoints;
    private List<GameObject> movementPointsSorted;

    /*void Awake()
    {
        movementPoints = new List<GameObject>();
        movementPoints.Add(GameObject.FindGameObjectsWithTag("MovementPoint"));
        
        while (movementPoints. > 0)
        {
            foreach (GameObject MovementPoint in movementPoints)
            {
                if ((movementPointsSorted.Length == MovementPoint.GetComponent<MovementPoints>().movementIndex))
                {
                    movementPointsSorted 
                }
            }
        }

        StartCoroutine(EnemyMovement());
    }*/

    IEnumerator EnemyMovement()
    {
        while (enemyHealth > 0 && movementProgress < 10)
        {
            while (transform.position.x > 6.5 && movementProgress == 0 && enemyHealth > 0)
            {
                transform.position -= new Vector3((enemySpeed / 100), 0, 0);
                yield return new WaitForSecondsRealtime(0.01f);
            }

            if (transform.position.x != 6.5 && movementProgress == 0)
            {
                transform.position = new Vector3(6.5f, transform.position.y);
            }
            movementProgress++;


            while (transform.position.y < 1.5 && movementProgress == 1 && enemyHealth > 0)
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
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

}