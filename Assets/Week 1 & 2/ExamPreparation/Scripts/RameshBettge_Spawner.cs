using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RameshBettge_Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPrefab();
        }
    }

    void SpawnPrefab()
    {
        Quaternion rot = transform.rotation;

        Instantiate(prefabToSpawn, transform.position, rot);
    }
}
