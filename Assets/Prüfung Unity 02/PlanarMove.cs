using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanarMove : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(x, 0, z);
        rb.AddForce(moveVector);
    }

    void OnCollisionEnter(Collision collision)
    { 
        print(collision.gameObject.name);
    }
}
