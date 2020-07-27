using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 1;
    [SerializeField]
    private float spawnPosZ = 3;
    private float interval = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, spawnPosZ);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[Random.Range(0, 2)], spawnPos, ballPrefabs[0].transform.rotation);
    }

    private void Update()
    {
        if (interval >= spawnInterval)
        {
            SpawnRandomBall();
            spawnInterval = Random.Range(1, 5);
            interval = 0;
        }
        interval = interval + (1 * Time.deltaTime);
    }

}
