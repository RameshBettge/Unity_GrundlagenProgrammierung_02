using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineGrid : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;

    [SerializeField]
    Vector2Int gridSize;

    [SerializeField]
    float sineOffsetIncrement;

    [SerializeField]
    float speed = 5f;

    GameObject[,] gridObjects;

    void Start()
    {
        CreateGrid();
    }

    private void Update()
    {
        UpdateGridWave();
    }

   

    private void CreateGrid()
    {
        gridObjects = new GameObject[gridSize.x, gridSize.y];
           

        for (int x = 0; x < gridSize.x -1; x++)
        {
            for (int z = 0; z < gridSize.y - 1; z++)
            {
                Vector3 spawnPos = GetGridPos(x, z);

                gridObjects[x, z] = Instantiate(prefab, spawnPos, Quaternion.identity, transform);
            }
        }
    }

    private void UpdateGridWave()
    {
        for (int x = 0; x < gridSize.x - 1; x++)
        {
            for (int z = 0; z < gridSize.y - 1; z++)
            {
                int gridIndex = x + z;

                float sine = Mathf.Sin(Time.time * speed + (gridIndex * sineOffsetIncrement));
                float sine01 = (sine * 0.5f) + 0.5f;

                Vector3 newPos = GetGridPos(x, z);


                newPos.y += sine01;

                gridObjects[x, z].transform.position = newPos;

                gridObjects[x, z].GetComponent<Renderer>().material.color = Color.Lerp(new Color(0.05f, 0.5f, 1), Color.green, sine01);
            }
        }
    }

    Vector3 GetGridPos(int x, int z)
    {
        return transform.position + new Vector3(x, 0, z);
    }
}
