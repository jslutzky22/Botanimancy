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
    public PlayerScript playerScript;
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
            playerScript.mouseIndicator.SetActive(false);
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
            playerScript.mouseIndicator.GetComponent<SpriteRenderer>().sprite = playerScript.towerOneSprite;
            playerScript.mouseIndicator.SetActive(true);
            descriptionBackground.SetActive(true);
            descriptionText.text = "Attacks fast with medium damage.\r\nUpgrade: Summons wolf pup that has greater range but deals less damage.";
        }
        else if (TowerType == 2)
        {
            playerScript.mouseIndicator.GetComponent<SpriteRenderer>().sprite = playerScript.towerTwoSprite;
            playerScript.mouseIndicator.SetActive(true);
            descriptionBackground.SetActive(true);
            descriptionText.text = "Attacks slow but hits hard.\r\nUpgrade: Increases in size and deals double damage.";
        }
        else if (TowerType == 3)
        {
            playerScript.mouseIndicator.GetComponent<SpriteRenderer>().sprite = playerScript.towerThreeSprite;
            playerScript.mouseIndicator.SetActive(true);
            descriptionBackground.SetActive(true);
            descriptionText.text = "Fires webs that slow enemies down and attacks enemies up close.\r\nUpgrade: Whenever spider kills an enemy, it spawns a mini spider with greater range but deals less damage";
        }
        else if (TowerType == 4)
        {
            playerScript.mouseIndicator.GetComponent<SpriteRenderer>().sprite = playerScript.towerFourSprite;
            playerScript.mouseIndicator.SetActive(true);
            descriptionBackground.SetActive(true);
            descriptionText.text = "Casts slow-moving fireballs at a distance.\r\nUpgrade: Grows two more heads and increases damage.";
        }
        else if (TowerType == 5)
        {
            playerScript.mouseIndicator.GetComponent<SpriteRenderer>().sprite = playerScript.towerFiveSprite;
            playerScript.mouseIndicator.SetActive(true);
            descriptionBackground.SetActive(true);
            descriptionText.text = "Gives plantimals nutrients and unlocks boons unique to each creature.";
        }
    }
}
