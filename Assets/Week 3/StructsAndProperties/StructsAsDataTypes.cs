using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructsAsDataTypes : MonoBehaviour
{
    public int someInt = 1;


    void Start()
    {
        DoSthWithVectorUser(this);
        print(this.someInt);


        Vector3 myVector = new Vector3(1, 0, 0);
        ModifyVector(myVector);

        print(myVector);
    }


    void ModifyInt(int givenInt)
    {
        givenInt *= 2;
    }


    void DoSthWithVectorUser(StructsAsDataTypes user)
    {
        user.someInt *= 2;
    }

    void ModifyVector(Vector3 vector3)
    {
        vector3 *= 2;
    }
}
