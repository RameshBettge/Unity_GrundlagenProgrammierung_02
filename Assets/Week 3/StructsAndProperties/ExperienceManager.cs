using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceManager : MonoBehaviour
{
    private int experience = 1000;

    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    void GainExperience(int experienceToGain)
    {
        experience += experienceToGain;
        // play Particle effect
        // Notify other class

        // check if level up
        // -> Bigger Particle effect
        // -> Play soundeffect
    }

    private void Start()
    {
        print(Level + " (" + experience + ")");

        experience += 6000;

        print(Level + " (" + experience + ")");

    }
}
