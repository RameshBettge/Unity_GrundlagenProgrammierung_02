using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleScript : MonoBehaviour
{
    void Awake()
    {
        Invoke("MyLateStart", 4);//this will happen after 2 seconds

        Debug.Log("I Started");
        Debug.LogWarning("WARNING!");
        //Debug.LogError("ERROR!");
    }

    void MyLateStart()
    {
        print("I was delayed");
    }

    private void Update()
    {
        
    }
}
