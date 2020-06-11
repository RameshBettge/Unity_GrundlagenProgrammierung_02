using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NestedArraySpawner : MonoBehaviour
{
    public GameObject prefab;



    public int sizeX = 5;
    public int sizeZ = 10;

    public GameObject[,] spawnedPrefabs;

    void Start()
    {
        spawnedPrefabs = new GameObject[sizeX, sizeZ];

        for (int x = 0; x < sizeX; x++)
        {
            for (int z = 0; z < sizeZ; z++)
            {
                Vector3 pos = new Vector3(x, 0, z);
                GameObject spawnedPrefab = Instantiate(prefab, pos, Quaternion.identity);

                spawnedPrefabs[x, z] = spawnedPrefab;
            }
        }
    }
}
