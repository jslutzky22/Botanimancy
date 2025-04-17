using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveChecker : MonoBehaviour
{
    [SerializeField] private GameObject[] wave1;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(firstWave());
        foreach (GameObject enemy in wave1)
        {
            if (enemy != null) enemy.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (wave1 == null)
        {
            SceneManager.LoadScene("WinScene");
        }
        if (AllEnemiesDestroyed(wave1))
        {
            SceneManager.LoadScene("WinScene");
        }
    }


    private bool AllEnemiesDestroyed(GameObject[] enemies)
    {
        foreach (GameObject enemy in enemies)
        {
            if (enemy != null) return false;
        }
        return true;
    }
    /*private IEnumerator firstWave()
    {
        foreach (GameObject enemy in wave1)
        {
            if (enemy != null) enemy.SetActive(true);
        }
    }*/
    /*private bool AllEnemiesDestroyed(GameObject[] enemies)
    {
        foreach (GameObject enemy in enemies)
        {
            if (enemy != null) return false;
        }
        return true;
    }
    /*private bool IsArrayEmpty()
    {
        if (wave1 == null || wave1.Length == 0) return true;
        for (int i = 0; i < wave1.Length; i++)
        {
            if (wave1[i] != null)
            {
                return false;
            }

            
        }
        SceneManager.LoadScene("WinScene");
        Debug.Log("Won");
    }*/



}
