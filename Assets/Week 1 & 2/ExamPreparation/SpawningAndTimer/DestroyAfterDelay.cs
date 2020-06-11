using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterDelay : MonoBehaviour
{
    float timer = 0;
    public float lifeTime = 10;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > lifeTime)
        {
            Destroy(gameObject);
        }
    }
}
