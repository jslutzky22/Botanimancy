using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Vector2 enemySpawnPosition;

    [Header ("Wave One Part One")]
    [SerializeField] private float timeBeforeFirstWaveSpawns;
    [SerializeField] private int amountOfEnemiesInFirstPartOfWave;
    [SerializeField] private float timeBetweenEachEnemySpawnOne;
    [SerializeField] private GameObject firstEnemySpawned;
    [SerializeField] private float timeBeforeNextEnemiesSpawnOne;
    
    [Header("Wave One Part Two")]
    [SerializeField] private int amountOfEnemiesInSecondPartOfWave;
    [SerializeField] private float timeBetweenEachEnemySpawnTwo;
    [SerializeField] private GameObject secondEnemySpawned;
    [SerializeField] private float timeBeforeNextEnemiesSpawnTwo;

    [Header("Wave One Part Three")]
    [SerializeField] private int amountOfEnemiesInThirdPartOfWave;
    [SerializeField] private float timeBetweenEachEnemySpawnThree;
    [SerializeField] private GameObject thirdEnemySpawned;

    [Header("Wave Two Part One")]
    [SerializeField] private float timeBeforeSecondWaveSpawns;
    [SerializeField] private int amountOfEnemiesInFirstPartOfSecondWave;
    [SerializeField] private float timeBetweenEachEnemySpawnFour;
    [SerializeField] private GameObject fourthEnemySpawned;
    [SerializeField] private float timeBeforeNextEnemiesSpawnThree;
    
    [Header("Wave Two Part Two")]
    [SerializeField] private int amountOfEnemiesInSecondPartOfSecondWave;
    [SerializeField] private float timeBetweenEachEnemySpawnFive;
    [SerializeField] private GameObject fifthEnemySpawned;
    [SerializeField] private float timeBeforeNextEnemiesSpawnFour;

    [Header("Wave Two Part Three")]
    [SerializeField] private int amountOfEnemiesInThirdPartOfSecondWave;
    [SerializeField] private float timeBetweenEachEnemySpawnSix;
    [SerializeField] private GameObject sixthEnemySpawned;

    [Header("Other")]
    public int enemiesAlive;

    private int wavesSent;
    AudioSource audioSource;
    [SerializeField] private AudioClip waveStart;
    [SerializeField] private AudioClip waveComplete;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void StartWaves()
    {
        audioSource.PlayOneShot(waveStart, 0.2F);
        StartCoroutine(WaveOne());
    }

    IEnumerator WaveOne()
    {
        yield return new WaitForSecondsRealtime(timeBeforeFirstWaveSpawns);
        while (amountOfEnemiesInFirstPartOfWave > 0)
        {
            Instantiate(firstEnemySpawned, enemySpawnPosition, Quaternion.identity);
            enemiesAlive++;
            yield return new WaitForSecondsRealtime(timeBetweenEachEnemySpawnOne);
            amountOfEnemiesInFirstPartOfWave--;
        }
        if (amountOfEnemiesInFirstPartOfWave == 0)
        {
            wavesSent++;
        }
        yield return new WaitForSecondsRealtime(timeBeforeNextEnemiesSpawnOne);
        while (amountOfEnemiesInSecondPartOfWave > 0)
        {
            Instantiate(secondEnemySpawned, enemySpawnPosition, Quaternion.identity);
            enemiesAlive++;
            yield return new WaitForSecondsRealtime(timeBetweenEachEnemySpawnTwo);
            amountOfEnemiesInSecondPartOfWave--;
        }
        if (amountOfEnemiesInSecondPartOfWave == 0)
        {
            wavesSent++;
        }
        yield return new WaitForSecondsRealtime(timeBeforeNextEnemiesSpawnTwo);
        while (amountOfEnemiesInThirdPartOfWave > 0)
        {
            Instantiate(thirdEnemySpawned, enemySpawnPosition, Quaternion.identity);
            enemiesAlive++;
            yield return new WaitForSecondsRealtime(timeBetweenEachEnemySpawnThree);
            amountOfEnemiesInThirdPartOfWave--;
        }
        if (amountOfEnemiesInThirdPartOfWave == 0)
        {
            wavesSent++;
        }

        while (enemiesAlive > 0)
        {
            yield return new WaitForSecondsRealtime(0.1f);
        }
        if (enemiesAlive == 0 && wavesSent == 3)
        {
            audioSource.PlayOneShot(waveComplete, 1F);
            StartCoroutine(WaveTwo());
        }
    }

    IEnumerator WaveTwo()
    {
        yield return new WaitForSecondsRealtime(timeBeforeSecondWaveSpawns);
        while (amountOfEnemiesInFirstPartOfSecondWave > 0)
        {
            Instantiate(fourthEnemySpawned, enemySpawnPosition, Quaternion.identity);
            enemiesAlive++;
            yield return new WaitForSecondsRealtime(timeBetweenEachEnemySpawnFour);
            amountOfEnemiesInFirstPartOfSecondWave--;
        }
        if (amountOfEnemiesInFirstPartOfSecondWave == 0)
        {
            wavesSent++;
        }
        yield return new WaitForSecondsRealtime(timeBeforeNextEnemiesSpawnThree);
        while (amountOfEnemiesInSecondPartOfSecondWave > 0)
        {
            Instantiate(fifthEnemySpawned, enemySpawnPosition, Quaternion.identity);
            enemiesAlive++;
            yield return new WaitForSecondsRealtime(timeBetweenEachEnemySpawnFive);
            amountOfEnemiesInSecondPartOfSecondWave--;
        }
        if (amountOfEnemiesInSecondPartOfSecondWave == 0)
        {
            wavesSent++;
        }
        yield return new WaitForSecondsRealtime(timeBeforeNextEnemiesSpawnFour);
        while (amountOfEnemiesInThirdPartOfSecondWave > 0)
        {
            Instantiate(sixthEnemySpawned, enemySpawnPosition, Quaternion.identity);
            enemiesAlive++;
            yield return new WaitForSecondsRealtime(timeBetweenEachEnemySpawnSix);
            amountOfEnemiesInThirdPartOfSecondWave--;
        }
        if (amountOfEnemiesInThirdPartOfSecondWave == 0)
        {
            wavesSent++;
        }

        while (enemiesAlive > 0)
        {
            yield return new WaitForSecondsRealtime(0.1f);
        }
        if (enemiesAlive <= 0 && wavesSent == 6)
        {
            //Debug.Log("Enemies all dead");
            SceneManager.LoadScene("WinScene");
        }

    }

    private void Update()
    {
        //if (enemiesAlive <= 0)
        //{
        //    Debug.Log("Enemies all dead");
        //    //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //    SceneManager.LoadScene("WinScene");
        //}
    }
}
