using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    [SerializeField] private GameObject descriptionBackground;
    [SerializeField] private TMP_Text descriptionText;

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
            descriptionBackground.SetActive(false);
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

        if (TowerType == 1)
        {
            descriptionBackground.SetActive(true);
            descriptionText.text = "Wolfsbane Tower: put desc. here";
        }
        else if (TowerType == 2)
        {
            descriptionBackground.SetActive(true);
            descriptionText.text = "Dandelion Tower: put desc. here";
        }
        else if (TowerType == 3)
        {
            descriptionBackground.SetActive(true);
            descriptionText.text = "Spiderlily Tower: put desc. here";
        }
        else if (TowerType == 4)
        {
            descriptionBackground.SetActive(true);
            descriptionText.text = "Dragonfruit Tower: put desc. here";
        }
        else if (TowerType == 5)
        {
            descriptionBackground.SetActive(true);
            descriptionText.text = "Upgrade Towers: put desc. here";
        }
    }
}
