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
            GetComponent<SpriteRenderer>().color = new Color(0.5188679f, 0.4534298f, 0.2667764f);
        }
    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = new Color(0.3679245f, 0.3345163f, 0.2342916f);
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
