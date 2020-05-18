using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollABall_Turret : MonoBehaviour
{
    public GameObject player;

    public GameObject bulletPrefab;

    public float spawnOffset = 2f;

    public float spawnInterval = 1;

    float timer = 0;


    void Update()
    {
        RotateTowardsPlayer();

        if(timer >= spawnInterval)
        {
            SpawnBullet();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void RotateTowardsPlayer()
    {
        transform.LookAt(player.transform);
    }

    void SpawnBullet()
    {
        Vector3 spawnPosition = transform.position + transform.forward * spawnOffset;

        Quaternion spawnRotation = Quaternion.LookRotation(transform.forward);

        Instantiate(bulletPrefab, spawnPosition, spawnRotation);
    }
}
