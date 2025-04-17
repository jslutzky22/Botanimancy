using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class TowerPlacement : MonoBehaviour
{
    [SerializeField] private int TowerType;
    private GameObject sceneCamera;
    private PlayerScript playerScript;
    private GameObject[] greenTiles;

    private void Start()
    {
        sceneCamera = FindObjectOfType<Camera>().gameObject;
        playerScript = sceneCamera.GetComponent<PlayerScript>();
    }

    private void Update()
    {
        
    }

    private void OnMouseDown()
    {
        playerScript.towerSelected = TowerType;
        //Debug.Log(TowerType);
        playerScript.selectedTileTransform = null;

        greenTiles = GameObject.FindGameObjectsWithTag("GreenTile");

        foreach (GameObject GreenTiles in greenTiles)
        {
            GreenTiles.GetComponent<GreenTileScript>().selected = false;
        }
    }
}
