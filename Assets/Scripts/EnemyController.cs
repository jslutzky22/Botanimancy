using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int enemyHealth;
    public int enemySpeed;
    private int movementProgress = 0;

    private void Start()
    {
        while (transform.position.x > 6.5 && movementProgress == 0)
        {
            transform.position -= new Vector3 ((enemySpeed / 10), 0, 0);
        }  
    }
}
