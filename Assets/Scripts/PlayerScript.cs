using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    PlayerInput playerInput;
    public int towerSelected;
    public Transform selectedTileTransform;
    private GameObject selectedTile;
    private GameObject[] greenTiles;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        if (towerSelected != 0 && selectedTileTransform != null)
        {
            greenTiles = GameObject.FindGameObjectsWithTag("GreenTile");

            foreach (GameObject GreenTiles in greenTiles)
            {
                if (GreenTiles.GetComponent<GreenTileScript>().selected == true)
                {
                    selectedTile = GreenTiles;
                }
            }

            if (towerSelected == 1)
            {
                
            }
            else if (towerSelected == 2)
            {

            }
            else if (towerSelected == 3)
            {

            }
            else if (towerSelected == 4)
            {

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
