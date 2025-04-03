using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTileScript : MonoBehaviour
{
    private GameObject[] greenTiles;
    public bool selected;

    [SerializeField] private int xCoordinate;
    [SerializeField] private int yCoordinate;

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
