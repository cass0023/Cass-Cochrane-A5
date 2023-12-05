using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public float platformCount;
    public Vector3 spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (float i = 0; i < platformCount; i++)
        {
            spawnPosition.y = Random.Range(-15f, 100f);
            spawnPosition.x = Random.Range(-12f, 12f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
