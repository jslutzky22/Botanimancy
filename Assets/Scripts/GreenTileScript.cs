using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTileScript : MonoBehaviour
{
    private GameObject[] greenTiles;
    public bool selected;

    [SerializeField] private float xCoordinate;
    [SerializeField] private float yCoordinate;

    private void Start()
    {
        xCoordinate = transform.localPosition.x;
        yCoordinate = transform.localPosition.y;
    }

    private void OnMouseDown()
    {
        greenTiles = GameObject.FindGameObjectsWithTag("GreenTile");

        foreach (GameObject GreenTiles in greenTiles)
        {
            GreenTiles.GetComponent<GreenTileScript>().selected = false;
        }

        this.selected = true;
        Debug.Log(this.xCoordinate + " " + this.yCoordinate);
    }
}
