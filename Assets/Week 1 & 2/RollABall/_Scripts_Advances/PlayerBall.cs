using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    public float speed;
    public float extraGravity = 8f;

    public RollABall_CameraTarget cameraTarget;

    float spawnOffset = 4f;

    private Rigidbody rb;

    bool isGrounded;

    Vector3 startPosition;

    float deathHeight = -25f;

    float floatMoveMultiplier = 0.5f;

    int numCollisions;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        startPosition = transform.position;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.01f, moveVertical);

        Vector3 movement = cameraTarget.transform.right * moveHorizontal;
        movement += cameraTarget.transform.forward * moveVertical;

        if (!isGrounded)
        {
            movement *= floatMoveMultiplier;
            movement.y = -extraGravity * Time.deltaTime;
        }

        rb.AddForce(movement * speed);
    }

    private void Update()
    {
        if(transform.position.y <= deathHeight)
        {
            OnDeath();
        }
    }

    public void OnDeath()
    {
        transform.position = startPosition + Vector3.up * spawnOffset;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        numCollisions = 0;

        cameraTarget.ResetRotation();
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;

        numCollisions++;
    }

    private void OnCollisionExit(Collision collision)
    {
        numCollisions--;

        if(numCollisions == 0)
        {
            isGrounded = false;
        }
    }
}
