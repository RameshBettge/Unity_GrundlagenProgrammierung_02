using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Custom : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 0;
    public float maxSpeed = 10;

    public float acceleration = 0.01f;

    public float drag = 0.01f;

    public float rotationSpeed = 10;
    float rotationInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    private void Update()
    {
        float inputV = Input.GetAxis("Vertical");
        float accelerationInput = Mathf.Max(inputV, 0f);

        speed += accelerationInput * acceleration;

        speed = Mathf.Min(maxSpeed, speed);

        float inputH = Input.GetAxis("Horizontal");
        rotationInput = inputH * rotationSpeed;
    }

    void FixedUpdate()
    {
        Move();
        Rotate();
    }

    private void Rotate()
    {
        Quaternion targetRotation = transform.rotation * Quaternion.Euler(0, rotationInput * Time.fixedDeltaTime, 0);

        rb.MoveRotation(targetRotation);
    }

    private void Move()
    {
        Vector3 targetPos = transform.position + transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(targetPos);

        speed *= 1 - drag;
    }
}
