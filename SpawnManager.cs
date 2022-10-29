using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabsDown;
    public GameObject[] animalPrefabsToRight;
    private float spawnRangeX = 18;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalDown", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalToRight", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void SpawnRandomAnimalDown()
    {
        int animalIndex = Random.Range(0, animalPrefabsDown.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabsDown[animalIndex], spawnPos, animalPrefabsDown[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalToRight()
    {
        int animalIndex = Random.Range(0, animalPrefabsToRight.Length);
        Vector3 spawnPos = new Vector3(-25.0f, 0, Random.Range(-5.0f, 15.0f));

        Instantiate(animalPrefabsToRight[animalIndex], spawnPos, animalPrefabsToRight[animalIndex].transform.rotation);
    }

}
