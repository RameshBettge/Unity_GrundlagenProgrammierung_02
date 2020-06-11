using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto_Ingeneur : MonoBehaviour
{
    Auto_Blaupause autoInstanz;

    void Start()
    {
        autoInstanz.mainColor = Color.white;

        Auto_Blaupause.maxSpeed = 120;
    }

    void Update()
    {
        
    }
}
