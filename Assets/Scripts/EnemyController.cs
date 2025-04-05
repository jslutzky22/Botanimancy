using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int enemyHealth;
    public float enemySpeed;
    private int movementProgress = 0;

    private void Start()
    {
        StartCoroutine(EnemyMovement());
    }

    IEnumerator EnemyMovement()
    {
        while (transform.position.x > 6.5 && movementProgress == 0)
        {
            transform.position -= new Vector3((enemySpeed / 100), 0, 0);
            yield return new WaitForSecondsRealtime(0.01f);
        }

        if (transform.position.x != 6.5)
        {
            transform.position = new Vector3 (6.5f, transform.position.y);
        }
        movementProgress++;
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