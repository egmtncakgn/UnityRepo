using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject prefab, bPrefab;
    public float spawnZaman;
    public int level, spawnSayi;

    void Start()
    {
        level = 1;
        spawnZaman = 5f;
        spawnSayi = 10;

        
    }

    void SpawnEt()
    {
        if(spawnZaman <= 0)
        {
            Vector3 position = new Vector3(Random.Range(-3f, 3f), 8, -10);
            Instantiate(prefab, position, Quaternion.identity);

            spawnZaman = 5f;
        }
    }

    void Update()
    {
        spawnZaman -= 3 * Time.deltaTime;

        SpawnEt();
        
    }
}
