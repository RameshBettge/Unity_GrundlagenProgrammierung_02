using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int field_HealthPoints = 100;
    public bool setAliveOnSpace = true;

    List<int> numbers = new List<int>();

    public int HealthPoints
    {
        get
        {
            return field_HealthPoints;
        }
        set
        {
            if (field_HealthPoints > 0)
            {
                if (value < 1)
                {
                    OnDeath();
                }
            }

            field_HealthPoints = value;
        }
    }

    public bool IsAlive
    {
        get
        {
            bool hasHealthPointsLeft = field_HealthPoints > 0;
            return hasHealthPointsLeft;
        }
        set
        {
            if (value == true)
            {
                if (HealthPoints < 1)
                {
                    HealthPoints = 1;
                }
            }
            else
            {
                HealthPoints = 0;
            }
        }
    }

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsAlive = setAliveOnSpace;
            print("IsAlive: " + IsAlive + " - HealthPoints = " + HealthPoints);
        }
    }

    private void OnDeath()
    {
        // Death animation and sound effect.
        // Display Dark Souls 'You Died' screen or GTA 'WASTED' screen.

        print("OnDeath called.");
    }







}
