using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollABall_CameraDirectionGiver : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        RollABall_CameraTarget camTarget = other.GetComponentInChildren<RollABall_CameraTarget>();

        if(camTarget)
        {
            camTarget.ReceiveNewDirection(transform);
        }
    }
}
