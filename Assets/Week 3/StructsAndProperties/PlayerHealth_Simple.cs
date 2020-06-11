using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth_Simple : MonoBehaviour
{
    public int healthPoints = 50;

    public bool IsAlive
    {
        get
        {
            bool hasHealthPointsLeft = healthPoints > 0;

            return hasHealthPointsLeft;
        }
        set
        {
            // Player is alive
            if(value)
            {
                healthPoints = 100;
            }
            // Player is not alive
            else
            {
                healthPoints = 0;
            }
        }
    }

    private void Start()
    {
        IsAlive = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print(IsAlive);
        }
    }
}
