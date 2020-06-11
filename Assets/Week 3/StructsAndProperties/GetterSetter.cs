using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterSetter : MonoBehaviour
{

    int experiencePoints;

    public int ExperiencePoints
    {
        get
        {
            return experiencePoints;    
        }
        private set
        {
            experiencePoints = value;
            // Play Particle Effect
            // Show XP Number on screen
        }
    }



    public void AddExperiencePoints(int XP)
    {
        ExperiencePoints += XP;
    }
}

public class XP_Giver : MonoBehaviour
{
    public GetterSetter experienceManager;

    private void Start()
    {
        //int playerXP = experienceManager.GetExperiencePoints();
        int playerXP = experienceManager.ExperiencePoints;
    }

    private void OnDestroy()
    {
        experienceManager.AddExperiencePoints(10);
    }
}