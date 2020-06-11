using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 0.1f;

    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
    }
}