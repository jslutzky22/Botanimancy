using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureSpawner : MonoBehaviour
{
    public GameObject wolfsbanePrefab;
    public Wolfsbane wolfsbane;
    

    void Start()
    {
        // Example placement at (3, 0)
        GameObject wolf = Instantiate(wolfsbanePrefab, new Vector3(4, 0, 0), Quaternion.identity);
        wolf.GetComponent<BaseCreature>().Place(new Vector3(4, 0, 0));
        wolfsbane.isPlaced = true;
    }
}
