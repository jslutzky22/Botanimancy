using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTileScript : MonoBehaviour
{
    private GameObject[] greenTiles;
    public bool selected;

    [SerializeField] private float xCoordinate;
    [SerializeField] private float yCoordinate;
    private GameObject sceneCamera;
    private PlayerScript playerScript;
    public bool towerOnTile = false;

    private void Start()
    {
        xCoordinate = transform.localPosition.x;
        yCoordinate = transform.localPosition.y;
        sceneCamera = FindObjectOfType<Camera>().gameObject;
        playerScript = sceneCamera.GetComponent<PlayerScript>();
    }

    private void OnMouseUp()
    {
        greenTiles = GameObject.FindGameObjectsWithTag("GreenTile");

        foreach (GameObject GreenTiles in greenTiles)
        {
            GreenTiles.GetComponent<GreenTileScript>().selected = false;
        }

        if (!towerOnTile)
        {
            this.gameObject.tag = "selectedTile";
            playerScript.selectedTileTransform = this.transform;
        }
    }
}
