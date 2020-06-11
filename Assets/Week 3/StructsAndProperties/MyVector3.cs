using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct MyVector3
{
    public float x;
    public float y;
    public float z;

    public static MyVector3 right = new MyVector3(1, 0, 0);

    public MyVector3 Right
    {
        get
        {
            return new MyVector3(1, 0, 0);
        }
    }


    public float magnitude
    {
        get
        {
            return Mathf.Sqrt(x * x + y * y + z * z);
        }
    }


    // Dies ist ein custom constructor
    public MyVector3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static MyVector3 Lerp(MyVector3 a, MyVector3 b, float t)
    {
        a *= (1 - t);
        b *= t;

        return a + b;
    }


    public float GetMagnitude()
    {
        return Mathf.Sqrt(x * x + y * y + z * z);
    }

    // TODO: Show static function as alternative
    public MyVector3 CreateNewVector(float x, float y, float z)
    {
        MyVector3 newVector = new MyVector3();
        newVector.x = x;
        newVector.y = y;
        newVector.z = z;

        return newVector;
    }





    public static MyVector3 operator +(MyVector3 a, MyVector3 b)
    {
        MyVector3 sum = a;
        sum.x += b.x;
        sum.y += b.y;
        sum.z += b.z;

        return sum;
    }

    public static MyVector3 operator *(MyVector3 a, float scalar)
    {
        a.x *= scalar;
        a.y *= scalar;
        a.z *= scalar;

        return a;
    }
}
