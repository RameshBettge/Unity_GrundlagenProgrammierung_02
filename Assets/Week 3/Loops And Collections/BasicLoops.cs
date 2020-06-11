using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicLoops : MonoBehaviour
{
    public GameObject[] objects;



    private void Start()
    {


        //int counter = 0;

        //while (counter < numExecutions)
        //{
        //    print(counter);
        //    counter++;
        //}

        do
        {

        }
        while (0 > 1);


        // Wir finden heraus, ob unser objects-array ein objekt namens Sphere beinhaltet.
        for (int i = 0; i < objects.Length; i++)
        {
            string objectName = objects[i].name;

            print(objectName);

            if(objectName == "Sphere")
            {
                Debug.LogWarning("Sphere found! Breaking out of loop.");
                break;
            }
        }
    }
}