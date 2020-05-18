using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollABall_MovingPlatform : MonoBehaviour
{
    public AnimationCurve moveCurve;

    public float cycleLength = 10f;

    public float distance = 5f;

    Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position + transform.right * (distance * 0.5f);
    }

    void Update()
    {
        float repeatedTime = Mathf.Repeat(Time.time, cycleLength);

        float cycleTime = repeatedTime / cycleLength;

        float distanceMultiplier = moveCurve.Evaluate(cycleTime) - 1f;

        Vector3 currentOffset = transform.right * distanceMultiplier * distance;

        transform.position = startPosition + currentOffset;
    }
}
