using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_RB : MonoBehaviour
{
    Rigidbody rb;

    public float acceleration = 100f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 0, 1) * acceleration);
        }
    }
}
