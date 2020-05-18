using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRandomly : MonoBehaviour
{
    public float speed = 1f;

    void Start()
    {
        transform.rotation = Random.rotation;
    }

    void Update()
    {
        transform.Rotate(new Vector3(15f, 8f, 20f) * speed);
    }
}
