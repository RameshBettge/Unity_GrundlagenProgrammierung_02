using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPlayerController : MonoBehaviour
{
    public Transform[] players;

    public int activePlayerIndex;

    void Update()
    {
        float inputY = Input.GetAxisRaw("Vertical");

        players[activePlayerIndex].position += new Vector3(0, inputY, 0);
    }
}
