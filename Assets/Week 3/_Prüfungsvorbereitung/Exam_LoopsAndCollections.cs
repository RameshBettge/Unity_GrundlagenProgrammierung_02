using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exam_LoopsAndCollections : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;

    // Array
    GameObject[] gO_Array;
    public PommesBude[] buden;

    int[] numbers;

    // Liste
    public List<GameObject> gO_List;


    void Start()
    {
        // Arrays
        numbers = new int[5];
        print(numbers[0]);

        buden = FindObjectsOfType<PommesBude>();


        gO_Array = new GameObject[5];

        gO_Array[0] = cube;

        print(gO_Array[0].name);



        // Listen
        gO_List = new List<GameObject>();

        gO_List.Add(cube);
        gO_List.Add(sphere);
        gO_List.Add(cube);
        gO_List.Add(sphere);
        gO_List.Add(sphere);





        while (gO_List.Contains(cube))
        {
            gO_List.Remove(cube);
        }

        for (int i = gO_List.Count - 1; i > -1; i--)
        {
            if (gO_List[i] == cube)
            {
                gO_List.RemoveAt(i);
            }
        }

        foreach (GameObject gO in gO_List)
        {
            if(gO.transform.position.y < -100)
            {
                gO_List.Remove(gO);
            }
        }
    }
}
