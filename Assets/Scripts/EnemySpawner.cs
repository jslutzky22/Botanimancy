using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Vector2 enemySpawnPosition;

    [SerializeField] private float waveOneDelayStart;
    [SerializeField] private int waveOneSpawnOne;
    [SerializeField] private float waveOneSpawnOneDelay;
    [SerializeField] private GameObject waveOneSpawnOneEnemy;
    [SerializeField] private float waveOneDelayOne;
    [SerializeField] private int waveOneSpawnTwo;
    [SerializeField] private float waveOneSpawnTwoDelay;
    [SerializeField] private GameObject waveOneSpawnTwoEnemy;
    [SerializeField] private float waveOneDelayTwo;
    [SerializeField] private int waveOneSpawnThree;
    [SerializeField] private float waveOneSpawnThreeDelay;
    [SerializeField] private GameObject waveOneSpawnThreeEnemy;
    [SerializeField] private float waveOneDelayThree;

    [SerializeField] private float waveTwoDelayStart;
    [SerializeField] private int waveTwoSpawnOne;
    [SerializeField] private float waveTwoSpawnOneDelay;
    [SerializeField] private GameObject waveTwoSpawnOneEnemy;
    [SerializeField] private float waveTwoDelayOne;
    [SerializeField] private int waveTwoSpawnTwo;
    [SerializeField] private float waveTwoSpawnTwoDelay;
    [SerializeField] private GameObject waveTwoSpawnTwoEnemy;
    [SerializeField] private float waveTwoDelayTwo;
    [SerializeField] private int waveTwoSpawnThree;
    [SerializeField] private float waveTwoSpawnThreeDelay;
    [SerializeField] private GameObject waveTwoSpawnThreeEnemy;
    [SerializeField] private float waveTwoDelayThree;

    public int enemiesAlive;

    private void Awake()
    {
        StartCoroutine(WaveOne());
    }

    IEnumerator WaveOne()
    {
        yield return new WaitForSecondsRealtime(waveOneDelayStart);
        while (waveOneSpawnOne > 0)
        {
            Instantiate(waveOneSpawnOneEnemy, enemySpawnPosition, Quaternion.identity);
            enemiesAlive++;
            yield return new WaitForSecondsRealtime(waveOneSpawnOneDelay);
            waveOneSpawnOne--;
        }
        yield return new WaitForSecondsRealtime(waveOneDelayTwo);
        while (waveOneSpawnTwo > 0)
        {
            Instantiate(waveOneSpawnTwoEnemy, enemySpawnPosition, Quaternion.identity);
            enemiesAlive++;
            yield return new WaitForSecondsRealtime(waveOneSpawnTwoDelay);
            waveOneSpawnTwo--;
        }
        yield return new WaitForSecondsRealtime(waveOneDelayThree);
        while (waveOneSpawnThree > 0)
        {
            Instantiate(waveOneSpawnThreeEnemy, enemySpawnPosition, Quaternion.identity);
            enemiesAlive++;
            yield return new WaitForSecondsRealtime(waveOneSpawnThreeDelay);
            waveOneSpawnThree--;
        }

        if (enemiesAlive == 0)
        {
            StartCoroutine(WaveTwo());
        }
    }

    IEnumerator WaveTwo()
    {
        yield return new WaitForSecondsRealtime(waveTwoDelayStart);
        while (waveTwoSpawnOne > 0)
        {
            Instantiate(waveTwoSpawnOneEnemy, enemySpawnPosition, Quaternion.identity);
            enemiesAlive++;
            yield return new WaitForSecondsRealtime(waveTwoSpawnOneDelay);
            waveTwoSpawnOne--;
        }
        yield return new WaitForSecondsRealtime(waveTwoDelayTwo);
        while (waveTwoSpawnTwo > 0)
        {
            Instantiate(waveTwoSpawnTwoEnemy, enemySpawnPosition, Quaternion.identity);
            enemiesAlive++;
            yield return new WaitForSecondsRealtime(waveTwoSpawnTwoDelay);
            waveTwoSpawnTwo--;
        }
        yield return new WaitForSecondsRealtime(waveTwoDelayThree);
        while (waveTwoSpawnThree > 0)
        {
            Instantiate(waveTwoSpawnThreeEnemy, enemySpawnPosition, Quaternion.identity);
            enemiesAlive++;
            yield return new WaitForSecondsRealtime(waveTwoSpawnThreeDelay);
            waveTwoSpawnThree--;
        }

        if (enemiesAlive == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
