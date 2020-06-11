using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollABall_Pickup : MonoBehaviour
{
    private void Start()
    {
        transform.rotation = Random.rotation;
    }
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    public void OnCollected()
    {
        // Beweg dich nach oben
        // dreh dich
        // ...
    }
}
