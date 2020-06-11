using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicLists : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;

    public List<GameObject> objectList;
    public List<int> intList;

    private void Start()
    {
        // -- int list
        intList = new List<int>();

        intList.Add(1);
        intList.Add(2);
        intList.Add(3);
        intList.Add(4);
        intList.Add(5);

        intList.Remove(2);
        intList.Remove(3);

        // foreach(Typ Name in Collection)
        foreach(int number in intList)
        {
            print(number);
        }

        // -- objectList
        objectList = new List<GameObject>();

        objectList.Add(cube);
        objectList.Add(sphere);

        for (int i = 0; i < objectList.Count; i++)
        {
            //print(objectList[i].name);
        }


        foreach (GameObject gO in objectList)
        {
            print(gO.name);
        }

    }
}
