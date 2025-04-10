using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private float waveOneDelay;

    private void Awake()
    {
        StartCoroutine(WaveOne());
    }

    IEnumerator WaveOne()
    {
        yield return new WaitForSecondsRealtime(waveOneDelay);
    }
}
