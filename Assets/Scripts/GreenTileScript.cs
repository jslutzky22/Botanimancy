using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTileScript : MonoBehaviour
{
    private GameObject[] greenTiles;
    public bool selected;

    [SerializeField] private float xCoordinate;
    [SerializeField] private float yCoordinate;
    private PlayerScript playerScript;

    private void Start()
    {
        xCoordinate = transform.localPosition.x;
        yCoordinate = transform.localPosition.y;
    }

    private void OnMouseUp()
    {
        greenTiles = GameObject.FindGameObjectsWithTag("GreenTile");

        foreach (GameObject GreenTiles in greenTiles)
        {
            GreenTiles.GetComponent<GreenTileScript>().selected = false;
        }

        this.selected = true;
        playerScript.selectedTileTransform = this.transform;
    }
}
