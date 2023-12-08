using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public float platformsPerLevel;
    public GameObject characterLocation;
    private Vector3 spawnPosition;
    private float levelCheck;
    private float numberOfUnits = 2;
    private float lastPlatformY;

    void Start()
    {
        levelCheck = -platformsPerLevel / 2;
    }

    void Update()
    {
        //creates platforms into levels, starting with 2 units per platform
        if (characterLocation.transform.position.y > levelCheck)
        {
            spawnPosition = new Vector3();
            for (float i = 0; i < platformsPerLevel; i++)
            {
                spawnPosition.y = i * numberOfUnits + lastPlatformY;
                spawnPosition.x = Random.Range(-2.5f, 2.5f);
                Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            }
            levelCheck += platformsPerLevel * numberOfUnits;
            lastPlatformY += platformsPerLevel * numberOfUnits;
            numberOfUnits++;

        }
    }
}
