using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnPosition : MonoBehaviour
{
    public SphereCollider spawnArea;

    public GameObject prefabToSpawn;

    public float spawnUpOffset = 0;

    public Vector3 rayCastPos;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnSomething();
        }
    }

    void SpawnSomething()
    {
        rayCastPos = spawnArea.transform.position; // random position inside of sphere
        rayCastPos += new Vector3(0, 50, 0);


        float minOffset = -spawnArea.radius;
        float maxOffset = spawnArea.radius;

        float randomoffsetX = UnityEngine.Random.Range(minOffset, maxOffset);
        float randomoffsetZ = UnityEngine.Random.Range(minOffset, maxOffset);

        rayCastPos += new Vector3(randomoffsetX, 0, randomoffsetZ);

        RaycastHit hit;

        if (Physics.Raycast(rayCastPos, Vector3.down, out hit))
        {
            Vector3 spawnPos = hit.point + Vector3.up * spawnUpOffset;

            Instantiate(prefabToSpawn, spawnPos, Quaternion.identity);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(rayCastPos, Vector3.one);
    }
}
