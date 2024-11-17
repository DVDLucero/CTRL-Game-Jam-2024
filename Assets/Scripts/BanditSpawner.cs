using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditSpawner : MonoBehaviour
{
    public GameObject[] banditPrefabs; // Array to hold the 3 bandit prefabs
    public Transform[] spawnPoints;    // Array of spawn points where bandits can appear
    public int numberOfBandits = 5;    // Total number of bandits to spawn

    void Start()
    {
        SpawnBandits();
    }

    void SpawnBandits()
    {
        for (int i = 0; i < numberOfBandits; i++)
        {
            // Randomly select a bandit prefab
            GameObject banditPrefab = banditPrefabs[Random.Range(0, banditPrefabs.Length)];

            // Randomly select a spawn point
            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            // Instantiate the bandit at the chosen spawn point
            Instantiate(banditPrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}