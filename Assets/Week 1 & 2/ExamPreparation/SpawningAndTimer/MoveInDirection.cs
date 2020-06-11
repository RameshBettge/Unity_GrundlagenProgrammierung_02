using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInDirection : MonoBehaviour
{
    public Vector3 moveDir;

    public float speed = 5f;

    void Update()
    {
        transform.position += moveDir * speed;
    }
}
