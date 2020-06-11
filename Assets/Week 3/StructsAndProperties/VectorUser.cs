using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorUser : MonoBehaviour
{
    void Start()
    {
        Vector3 vec = new Vector3(1, 0, 0);

        // -- Default Constructor
        //MyVector3 myVector = new MyVector3();
        //myVector.x = 1;
        //myVector.y = 0;
        //myVector.z = 0;

        //// -- Custom Constructor
        //MyVector3 myVector = new MyVector3(1, 0, 0);
        //print(myVector.GetMagnitude());

        //myVector.x = 12;
        //print(myVector.magnitude);


        MyVector3 myVector = MyVector3.right;
    }
}
