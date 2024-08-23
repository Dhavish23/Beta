using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    int startDelay = 2;          // Delay before the first spawn
    float repeatInterval = 15.0f; // Time between spawns (15 seconds)
    float spawnRangeX = 15;       // Range on the X axis where objects can spawn
    float spawnPosZ = 20;         // Fixed Z position where objects will spawn

    // Start is called before the first frame update
    void Start()
    {
        // Start spawning with a delay and repeat every 15 seconds
        InvokeRepeating("SpawnRandomAnimal", startDelay, repeatInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // Optional code can go here if needed
    }

    void SpawnRandomAnimal()
    {
        // Randomly generate animal index and spawn position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
