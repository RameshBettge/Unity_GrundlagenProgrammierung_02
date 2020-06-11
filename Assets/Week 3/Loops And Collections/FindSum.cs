using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindSum : MonoBehaviour
{
    public int targetSum = 5;

    void Start()
    {
        for (int a = 1; a < targetSum; a++)
        {
            for (int b = 1; b < targetSum; b++)
            {


                if(a + b == targetSum)
                {
                    print(a + " + " + b + " == " + targetSum);
                }


            }
        }
    }
}
