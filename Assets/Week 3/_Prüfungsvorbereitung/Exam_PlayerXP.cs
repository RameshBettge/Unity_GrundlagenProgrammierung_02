using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exam_PlayerXP : MonoBehaviour
{
    public int experience = 1000;
    public int Experience
    {
        get
        {
            return experience;
        }
        set
        {
            experience = value;

            // Play ParticleSystem
            // Play Soundeffect
            // Display num of xp gained on screen
        }
    }



    public int Level
    {
        get
        {
            return Mathf.FloorToInt(experience / 1000);
        }
        set
        {
            experience = value * 1000;
        }
    }

    private void Start()
    {
        Level = 5;
    }


    public int GetLevel()
    {
        return Mathf.FloorToInt(experience / 1000);
    }

    public void SetLevel(int newLevel)
    {
        experience = newLevel * 1000;
    }
}
