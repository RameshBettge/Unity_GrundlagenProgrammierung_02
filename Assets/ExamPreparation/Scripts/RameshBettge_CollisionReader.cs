using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RameshBettge_CollisionReader : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
    }
}
