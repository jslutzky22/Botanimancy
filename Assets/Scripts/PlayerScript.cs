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
        if (plantFood == 0)
        {
            plantFood = 10;
        }
        //plantFood = 10;
    }

    // Update is called once per frame
    void Update()
    {

        //Vector3 mousePos = Input.mousePosition;
        
        plantFoodText.text = "Plant Food: " + plantFood;
        if (towerSelected != 0 && selectedTileTransform != null)
        {
            selectedTile = GameObject.FindGameObjectWithTag("selectedTile");
            Debug.Log(selectedTile);

            if (towerSelected == 1 && plantFood >= 5)
            {
                plantFood -= 5;
                selectedTile.GetComponent<GreenTileScript>().towerOnTile = true;
                Debug.Log(selectedTile);

                Instantiate(TowerOne, selectedTileTransform);
                //Instantiate(TowerOne, mousePos, Quaternion.identity);
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
        if (context.started)
        {
            if (towerSelected == 1 && plantFood >= 5)
            {
                Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Debug.Log("LeftClicked");
                plantFood -= 5;
                Instantiate(TowerOne, cursorPos, Quaternion.identity);
                towerSelected = 0;
            }
                //Vector3 mousePos = Input.mousePosition;
            /*Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("LeftClicked");
            plantFood -= 5;
            Instantiate(TowerOne, cursorPos, Quaternion.identity);*/
        }
           
    }
    public void RightClick(InputAction.CallbackContext context)
    {

        if (context.performed)
        {
            towerSelected = 0;
            Debug.Log("RightClicked");
        }
    }
}
