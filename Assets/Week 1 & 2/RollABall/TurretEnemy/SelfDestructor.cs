using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructor : MonoBehaviour
{
    public float lifeTime = 10;


    float startTime;

    private void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float passedTime = Time.time - startTime;

        if (passedTime > lifeTime)
        {
            Destroy(gameObject);
        }
    }
}
