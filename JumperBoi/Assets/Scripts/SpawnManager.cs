using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    

    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float spawnDelay = 2.0f;
    private float spawnInterval = 2.0f;
    private PlayerController playerControllerScript;


    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacles", spawnDelay, spawnInterval);
    }

    void Update()
    {
        
    }

    void SpawnObstacles()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
