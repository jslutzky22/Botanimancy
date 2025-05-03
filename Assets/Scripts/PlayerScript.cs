using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    PlayerInput playerInput;
    public int towerSelected;
    public Transform selectedTileTransform;
    private GameObject selectedTile;
    public int plantFood;
    [SerializeField] private TMP_Text plantFoodText;
    public GameObject notPlacableText;
    [SerializeField] private GameObject TowerOne;
    [SerializeField] private GameObject TowerTwo;
    [SerializeField] private GameObject TowerThree;
    [SerializeField] private GameObject TowerFour;

    public GameObject mouseIndicator;
    public Sprite towerOneSprite;
    public Sprite towerTwoSprite;
    public Sprite towerThreeSprite;
    public Sprite towerFourSprite;
    public Sprite towerFiveSprite;

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

        mouseIndicator.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10);
    }
    public void LeftClick(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (towerSelected == 1 && plantFood >= 5)
            {
                //Debug.Log("TowerClicked");
                Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(rayOrigin.origin, rayOrigin.direction);
                //Debug.Log("LeftClicked");
                /*if (hit.collider.tag == "Obstacle" || hit.collider.tag == "Wolf" || hit.collider.tag == "Lion")
                {
                    return;
                }*/
                //else
                //{
                    //Debug.Log("NotHittingObstacle");
                    //if (hit.collider.tag != "Obstacle")
                    //{
                    //Debug.Log("ShotObstacle");
                    if (hit.collider == null)
                    {
                    plantFood -= 5;
                        Instantiate(TowerOne, cursorPos, Quaternion.identity);
                    }
                else
                {
                    StartCoroutine(notPlacable());
                    //Debug.Log("NotPlaceable1");
                }
                   
                    //}
                //Debug.Log(hit.collider.tag);
                //if (hit.collider != null)
                //{
                    //Debug.Log(hit.collider.tag);
                    //plantFood -= 5;
                    //Instantiate(TowerOne, cursorPos, Quaternion.identity);
               // }
                //}
                towerSelected = 0;
            }
            if (towerSelected == 2 && plantFood >= 5)
            {
                Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(rayOrigin.origin, rayOrigin.direction);
                //Debug.Log("LeftClicked");
                if (hit.collider == null)
                {
                    plantFood -= 5;
                    Instantiate(TowerTwo, cursorPos, Quaternion.identity);
                }
                else
                {
                    StartCoroutine(notPlacable());
                    //Debug.Log("NotPlaceable1");
                }
                towerSelected = 0;
            }
            if (towerSelected == 3 && plantFood >= 5)
            {
                Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(rayOrigin.origin, rayOrigin.direction);
                //Debug.Log("LeftClicked");
                if (hit.collider == null)
                {
                    plantFood -= 5;
                    Instantiate(TowerThree, cursorPos, Quaternion.identity);
                }
                else
                {
                    StartCoroutine(notPlacable());
                    //Debug.Log("NotPlaceable1");
                }
                towerSelected = 0;
            }
            if (towerSelected == 4 && plantFood >= 5)
            {
                Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(rayOrigin.origin, rayOrigin.direction);
                //Debug.Log("LeftClicked");
                if (hit.collider == null)
                {
                    plantFood -= 5;
                    Instantiate(TowerFour, cursorPos, Quaternion.identity);
                }
                else
                {
                    StartCoroutine(notPlacable());
                    //Debug.Log("NotPlaceable1");
                }
                towerSelected = 0;
            }
            if (towerSelected == 5 && plantFood >= 10)
            {
                Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(rayOrigin.origin, rayOrigin.direction);
                //Debug.Log(hit.point);
                //Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
                //if (Physics.Raycast(rayOrigin, out hit) )
                //{
                if (hit.collider != null)
                {
                    // Debug.Log("Raycast Firing");
                    if (hit.collider.tag == "Wolf")
                    {
                        // Debug.Log("Raycast Found wolf");
                        if (hit.transform.gameObject.GetComponent<Wolfsbane>() == true)
                        {
                            if (hit.transform.gameObject.GetComponent<Wolfsbane>().upgraded == false)
                            {
                                hit.transform.gameObject.GetComponent<Wolfsbane>().upgrade();
                                plantFood -= 10;
                                towerSelected = 0;
                            }
                        }


                    }
                    if (hit.collider.tag == "Lion")
                    {
                        //Debug.Log("FoundLion");
                        if (hit.transform.gameObject.GetComponent<Dandelion>() == true)
                        {
                            if (hit.transform.gameObject.GetComponent<Dandelion>().upgraded == false)
                            {
                                //Debug.Log("LionUpgrading");
                                hit.transform.gameObject.GetComponent<Dandelion>().upgrade();
                                plantFood -= 10;
                                towerSelected = 0;
                            }
                        }
                    }
                    if (hit.collider.tag == "Spider")
                    {
                        //Debug.Log("FoundLion");
                        if (hit.transform.gameObject.GetComponent<SpiderLily>() == true)
                        {
                            if (hit.transform.gameObject.GetComponent<SpiderLily>().upgraded == false)
                            {
                                //Debug.Log("LionUpgrading");
                                hit.transform.gameObject.GetComponent<SpiderLily>().upgrade();
                                plantFood -= 10;
                                towerSelected = 0;
                            }
                        }
                    }



                    if (hit.collider.tag == "Dragon")
                    {
                        //Debug.Log("FoundLion");
                        if (hit.transform.gameObject.GetComponent<Dragonfruit>() == true)
                        {
                            if (hit.transform.gameObject.GetComponent<Dragonfruit>().upgraded == false)
                            {
                                //Debug.Log("LionUpgrading");
                                hit.transform.gameObject.GetComponent<Dragonfruit>().upgrade();
                                plantFood -= 10;
                                towerSelected = 0;
                            }
                        }
                    }
                    if (hit.transform.gameObject.GetComponent<SpawnThing>() == true)
                    {
                        //Debug.Log("Detected");
                        hit.transform.gameObject.GetComponent<SpawnThing>().forceUpgrade();

                    }
                    //hit.transform.gameObject.GetComponent<Wolfsbane>().upgraded = false;

                    // hit.transform.gameObject.GetComponent<Wolfsbane>().upgrade();

                }
                // }
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
            //Debug.Log("RightClicked");
        }
    }

    public void Restart(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private IEnumerator notPlacable()
    {
        {
            //Debug.Log("NotPlacable2");
            notPlacableText.SetActive(true);
            yield return new WaitForSeconds(2);
            notPlacableText.SetActive(false);
        }
    }
}
