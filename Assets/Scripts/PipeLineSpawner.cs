using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLineSpawner : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private PipeLine pipePrefab;
    [SerializeField] private float randomRange;
    [SerializeField] private float repeatTime;
    private Coroutine routine;

    private void OnEnable()
    {
        routine = StartCoroutine(SpawnRoutine());
    }

    private void OnDisable()
    {
        StopCoroutine(routine);
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(repeatTime);
            Vector2 spawnPos = spawnPoint.position + Vector3.up * Random.Range(-randomRange, randomRange);
            Instantiate(pipePrefab, spawnPos, Quaternion.identity);
        }
    }
}
