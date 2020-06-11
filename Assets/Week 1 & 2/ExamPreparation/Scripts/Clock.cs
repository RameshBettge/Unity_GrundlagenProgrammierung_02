using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public int seconds;

    public int minutes;

    float timeScale = 30f;

    public int intervalsPassed;

    public float intervalLength = 2f;
    float timer = 0;

    float lastExecutionTime;

    void Update()
    {
        //float passedTime = Time.time * timeScale;

        //minutes = Mathf.FloorToInt(passedTime / 60f);
        //seconds = Mathf.RoundToInt(passedTime - minutes * 60);


        // --- Execute in interval 01
        timer += Time.deltaTime;

        if (timer >= intervalLength)
        {
            print("Interval passed");
            intervalsPassed++;
            timer = 0;
        }

        //// --- Execute in interval 02
        //float timeSinceLastExecution = Time.time - lastExecutionTime;

        //if(timeSinceLastExecution >= intervalLength)
        //{
        //    print("Interval passed");
        //    intervalsPassed++;
        //    lastExecutionTime = Time.time;
        //}
    }
}
