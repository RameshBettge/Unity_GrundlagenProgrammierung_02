using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollABall_Bullet : MonoBehaviour
{
    public Transform particlePrefab;

    public float speed = 0.05f;

    public float explosionForce = 5f;


    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 targetPosition = transform.position + transform.forward * speed;
        rb.MovePosition(targetPosition);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (!other.isTrigger)
        {
            if (other.gameObject.GetComponent<PlayerBall>() != null)
            {
                Vector3 direction = other.transform.position - transform.position;
                direction = direction.normalized;

                other.gameObject.GetComponent<Rigidbody>().AddForce(direction * explosionForce, ForceMode.Impulse);
            }

            Instantiate(particlePrefab, transform.position, Quaternion.Euler(0, 0, 0));

            Destroy(gameObject);
        }
    }
}
