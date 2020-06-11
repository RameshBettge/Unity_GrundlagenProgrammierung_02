using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEMO_SimpleMove : MonoBehaviour
{
    public float speed = 4f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0f, v);

        transform.position += movement * speed * Time.deltaTime;
    }
}
