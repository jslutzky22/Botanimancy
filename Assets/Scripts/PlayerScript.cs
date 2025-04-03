using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    PlayerInput playerInput;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
