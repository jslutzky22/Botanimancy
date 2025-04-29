using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnThing : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wolfsbanePrefab;
    private Vector3 location;

    private LineRenderer lr;
    private List<Transform> lrPoints = new();
    //public bool upgradedWolf;
    public GameObject secondWolfsbanetower;
    public bool upgradeSuccess;
    public int towerType;
    private GameObject latestSpawnedWolf;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
        location = transform.position;
        
        GameObject wolf = Instantiate(wolfsbanePrefab, gameObject.transform.position, Quaternion.identity);
        lrPoints.Add(transform);
        lrPoints.Add(wolf.transform);

        BaseCreature creature = wolf.GetComponent<BaseCreature>();
        creature.Place(transform.position);
        latestSpawnedWolf = wolf;

        //SetUpLine;


        // wolf.GetComponent<BaseCreature>().Place(new Vector3(Position));

        // wolf.GetComponent<BaseCreature>(wolfsbanePrefab)
        //wolfsbane.isPlaced = true;
    }
    
    public void SetUpLine(List<Transform> points)
    {
        lr.positionCount = points.Count;
        this.lrPoints.AddRange(points);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < lrPoints.Count; i++)
        {
            lr.SetPosition(i, lrPoints[i].position);
        }
        if (towerType == 1 && latestSpawnedWolf.GetComponent<Wolfsbane>().upgraded == true && upgradeSuccess == false)
        {
            Debug.Log("TowerUpgraded");
            upgradeSuccess = true;
            GameObject wolf2 = Instantiate(secondWolfsbanetower, gameObject.transform.position, Quaternion.identity);
        }
    }
}
