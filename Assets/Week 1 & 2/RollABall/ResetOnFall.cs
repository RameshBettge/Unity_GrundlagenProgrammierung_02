using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetOnFall : MonoBehaviour
{
    public float resetHeight = -50;

    Rigidbody rb;

    Vector3 startPosition;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        startPosition = transform.position;
    }

    void Update()
    {
        if (transform.position.y < resetHeight)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = startPosition;

        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
