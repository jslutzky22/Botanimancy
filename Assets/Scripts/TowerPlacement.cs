using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    [SerializeField] private int TowerType;
    private PlayerScript playerScript;

    private void OnMouseDown()
    {
        playerScript.towerSelected = TowerType;   
    }

    private void OnMouseUp() 
    {
        playerScript.towerSelected = 0;
    }
}
