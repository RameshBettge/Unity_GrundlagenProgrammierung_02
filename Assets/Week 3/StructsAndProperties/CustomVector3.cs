using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomVector3 : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    public static CustomVector3 ZeroVector = new CustomVector3(0, 0, 0);
    public static CustomVector3 OneVector = new CustomVector3(1, 1, 1);
    //public static CustomVector3 OnVector = new CustomVector3();

    public float magnitude
    {
        get
        {
            return Mathf.Sqrt(x * x + y * y + z * z);
        }
    }

    public CustomVector3(float x, float y, float z)
    {
        this.x = x;
        this.x = y;
        this.x = z;
    }


    public static CustomVector3 operator +(CustomVector3 a, CustomVector3 b)
    {
        CustomVector3 sum = a;
        sum.x += b.x;
        sum.y += b.y;
        sum.z += b.z;

        return sum;
    }

    public static CustomVector3 operator *(CustomVector3 a, float scalar)
    {
        a.x *= scalar;
        a.y *= scalar;
        a.z *= scalar;
        
        return a;
    }

    public static CustomVector3 operator -(CustomVector3 a, CustomVector3 b)
    {
        CustomVector3 difference = a;
        difference.x -= b.x;
        difference.y -= b.y;
        difference.z -= b.z;

        return difference;
    }
}
