using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    PlayerInput playerInput;
    public int towerSelected;
    public Transform selectedTileTransform;
    private GameObject selectedTile;
    public int plantFood;
    [SerializeField] private TMP_Text plantFoodText;

    [SerializeField] private GameObject TowerOne;
    [SerializeField] private GameObject TowerTwo;
    [SerializeField] private GameObject TowerThree;
    [SerializeField] private GameObject TowerFour;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        plantFoodText.text = "Plant Food: " + plantFood;
        if (towerSelected != 0 && selectedTileTransform != null)
        {
            selectedTile = GameObject.FindGameObjectWithTag("selectedTile");

            if (towerSelected == 1 && plantFood >= 5)
            {
                plantFood -= 5;
                selectedTile.GetComponent<GreenTileScript>().towerOnTile = true;
                Instantiate(TowerOne, selectedTileTransform);
            }
            else if (towerSelected == 2 && plantFood >= 5)
            {
                plantFood -= 5;
                selectedTile.GetComponent<GreenTileScript>().towerOnTile = true;
                Instantiate(TowerTwo, selectedTileTransform);
            }
            else if (towerSelected == 3 && plantFood >= 5)
            {
                plantFood -= 5;
                selectedTile.GetComponent<GreenTileScript>().towerOnTile = true;
                Instantiate(TowerThree, selectedTileTransform);
            }
            else if (towerSelected == 4 && plantFood >= 5)
            {
                plantFood -= 5;
                selectedTile.GetComponent<GreenTileScript>().towerOnTile = true;
                Instantiate(TowerFour, selectedTileTransform);
            }
            towerSelected = 0;
            selectedTile.GetComponent<GreenTileScript>().selected = false;
            selectedTile = null;
        }
    }
    public void LeftClick(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("LeftClicked");
        }
           
    }
    public void RightClick(InputAction.CallbackContext context)
    {

        if (context.performed)
        {
            Debug.Log("RightClicked");
        }
    }
}
