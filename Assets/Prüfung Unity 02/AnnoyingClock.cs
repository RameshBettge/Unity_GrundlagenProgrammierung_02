using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnnoyingClock : MonoBehaviour
{
    float timer = 0;


    void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer >= 2)
        {
            print("Tick Tock");
            timer = 0;
        }
    }
}
