using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{

    public float upSpeed = 10f;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 upDir = Vector3.up;
            rb.AddForce(upDir * upSpeed);
        }
    }
}
