using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField]
    private GameObject[] animalPrefab;

    private float spawnPosZ = 20;
    private float spawnRangeX = 15;
    [SerializeField]
    private float spawnSpeed = 1.5f;
    [SerializeField]
    private float spawnStartTime = 2;
 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnStartTime, spawnSpeed);
    }

    // Update is called once per frame
    void Update()
    {
     
    }


    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);

    }
}
