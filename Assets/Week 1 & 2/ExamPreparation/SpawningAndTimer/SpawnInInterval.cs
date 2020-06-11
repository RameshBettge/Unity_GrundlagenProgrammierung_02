using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInInterval : MonoBehaviour
{
    float timer = 0;

    public float intervalLength = 5;

    float lastExecutionTime;

    public GameObject prefabToSpawn;

    void Update()
    {
        timer += Time.deltaTime;

        // if 5 seconds passed
        if (timer >= intervalLength)
        {
            Spawn();
            timer = 0;
        }


        //float passedTime = Time.time - lastExecutionTime;

        //if(passedTime >= intervalLength)
        //{
        //    Spawn();
        //    lastExecutionTime = Time.time;
        //}
    }



    void Spawn()
    {
        Vector3 spawnPos = transform.position + transform.up * 2;

        GameObject instantiatedPrefab = Instantiate(prefabToSpawn, spawnPos, Quaternion.identity);

        Vector3 targetMoveDir = transform.up;

        instantiatedPrefab.GetComponent<MoveInDirection>().moveDir = targetMoveDir;
    }
}
