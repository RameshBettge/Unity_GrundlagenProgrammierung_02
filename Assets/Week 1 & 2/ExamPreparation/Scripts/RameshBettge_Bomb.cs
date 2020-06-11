using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RameshBettge_Bomb : MonoBehaviour
{
    public float speed = 0.1f;

    void Update()
    {
        Vector3 pos = transform.position;
        pos += transform.up * speed;
        transform.position = pos;
    }
}
