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
    private bool colorChanged = false;
    [SerializeField] private Sprite normalSprite;
    [SerializeField] private Sprite clickedSprite;

    private void Start()
    {
        sceneCamera = FindObjectOfType<Camera>().gameObject;
        playerScript = sceneCamera.GetComponent<PlayerScript>();
    }

    private void Update()
    {
        if (playerScript.towerSelected != TowerType && colorChanged == true)
        {
            colorChanged = false;
            GetComponent<SpriteRenderer>().sprite = normalSprite;
        }
    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = clickedSprite;
        colorChanged = true;
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
