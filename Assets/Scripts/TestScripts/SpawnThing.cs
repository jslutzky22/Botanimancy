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
    public bool isDragon;
    public bool isWolf;
    public bool isLion;
    public bool isSpider;

    void Start()
    {
        if (isDragon == false)
        {
            lr = GetComponent<LineRenderer>();
            location = transform.position;

            GameObject wolf = Instantiate(wolfsbanePrefab, gameObject.transform.position, Quaternion.identity);
            lrPoints.Add(transform);
            lrPoints.Add(wolf.transform);

            BaseCreature creature = wolf.GetComponent<BaseCreature>();
            creature.Place(transform.position);
            latestSpawnedWolf = wolf;
        }
        else
        {
            GameObject wolf = Instantiate(wolfsbanePrefab, gameObject.transform.position, Quaternion.identity);
        }
       

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
    public void forceUpgrade()
    {
        if (isWolf == true)
        {
            latestSpawnedWolf.GetComponent<Wolfsbane>().upgrade();
        }
        if (isLion == true)
        {
            latestSpawnedWolf.GetComponent<Dandelion>().upgrade();
        }
        if (isSpider == true)
        {
            latestSpawnedWolf.GetComponent<SpiderLily>().upgrade();
        }
        if (isDragon == true)
        {
            latestSpawnedWolf.GetComponent<Dragonfruit>().upgrade();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragon == false)
        {
            for (int i = 0; i < lrPoints.Count; i++)
            {
                lr.SetPosition(i, lrPoints[i].position);
            }
            if (towerType == 1 && latestSpawnedWolf.GetComponent<Wolfsbane>().upgraded == true && upgradeSuccess == false)
            {
                //Debug.Log("TowerUpgraded");
                upgradeSuccess = true;
                GameObject wolf2 = Instantiate(secondWolfsbanetower, gameObject.transform.position, Quaternion.identity);
            }
        }
    }
}
