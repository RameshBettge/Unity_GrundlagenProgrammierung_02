using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollABall_CameraTarget : MonoBehaviour
{
    Rigidbody rb;

    Quaternion cachedRotation;

    Quaternion targetRotation;

    Quaternion startRotation;

    float rotationSpeed = 1f;

    private void Awake()
    {
        rb = transform.parent.GetComponent<Rigidbody>();

        startRotation = Quaternion.identity;
        cachedRotation = startRotation;
    }

    public void ReceiveNewDirection(Transform directionTransform)
    {
        targetRotation = Quaternion.LookRotation(directionTransform.forward);
    }

    public void ResetRotation()
    {
        cachedRotation = startRotation;
        targetRotation = startRotation;
        transform.rotation = targetRotation;
    }

    private void LateUpdate()
    {
        Vector3 moveDir = rb.velocity;
        moveDir.y = 0;

        if (moveDir.sqrMagnitude > 0.2f)
        {
            moveDir.Normalize();

            //Quaternion moveRotation = Quaternion.LookRotation(moveDir);
            //cachedRotation = Quaternion.Lerp(cachedRotation, moveRotation, rotationSpeed * Time.deltaTime);

            cachedRotation = Quaternion.Lerp(cachedRotation, targetRotation, rotationSpeed * Time.deltaTime);


            transform.rotation = cachedRotation;
        }
    }
}
