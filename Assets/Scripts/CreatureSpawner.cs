using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureSpawner : MonoBehaviour
{
    public GameObject spiderlilyprefab;
    public SpiderLily spiderLily;
    

    void Start()
    {
        // Example placement at (3, 0)
        GameObject wolf = Instantiate(spiderlilyprefab, new Vector3(4, 0, 0), Quaternion.identity);
        wolf.GetComponent<BaseCreature>().Place(new Vector3(4, 0, 0));
        spiderLily.isPlaced = true;
    }
}
