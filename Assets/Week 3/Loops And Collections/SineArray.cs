using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Dies Klasse erstellt eine Reihe von GameObjects, die sich wellenförmig nach oben und unten bewegen.
public class SineArray : MonoBehaviour
{
    // Referenz zu einem Prefab
    public GameObject prefab;

    // GameObject Array namens cubes
    public GameObject[] cubes;

    // Anzahl an objekten, die gespawned werden sollen.
    public int numObjects = 10;

    // Offset für die Sinusfunktion
    public float sinOffset = 0.2f;


    private void Start()
    {
        // Wir erstellen einen neuen Array mit der Länge numObjects.
        cubes = new GameObject[numObjects];

        // Wir verwenden einen loop um zwei code Zeilen mehrfach auszuführen 
        // Wie oft, wird durch numObjects vorgegeben.
        for (int i = 0; i < numObjects; i++)
        {
            // Wir erstellen einen neuen Vector3. Für jede iteration wird er um 1 auf der x Achse erhöht.
            Vector3 spawnPos = new Vector3(1, 0, 0) * i;
            // Wir instantiieren unser Prefab. 
            // Die Referenz zu dem Prefab speichern wir in unserem cubes Array an der Stelle i.
            cubes[i] = Instantiate(prefab, spawnPos, Quaternion.identity);
        }
    }

    

    void Update()
    {
        // Wir iterieren über alle Objekte, die in cubes referenziert sind.
        // numObjects entspricht der Länge von unserem Array
        for (int i = 0; i < numObjects; i++)
        {
            // Wir rechnen einen offset für die sinus-bewegung aus. Wir multiplizieren mit i, 
            // damit der Offset von cube zu cube gleichmäßig erhöht.
            float totalSinOffset = sinOffset * i;

            // Wir rufen die Sinusfunktion auf. 
            // Als Parameter übergeben wir die vergangene Zeit, damit sich der Wert mit der Zeit verändert.
            // Wir addieren vorher jedoch den totalSinOffset auf die Zeit, damit sich die Cubes verzögert (wellenartig bewegen)
            float sin = Mathf.Sin(Time.time + totalSinOffset);

            // Wir greifen auf den cube am index i zu.
            // Wir speichern die Position von dem cube in einen Vector3 namens cubePos.
            Vector3 cubePos = cubes[i].transform.position;

            // Wir setzen den y-Wert unseres Vectors auf unseren Sinus Wert
            cubePos.y = sin;

            // Wir greifen wieder auf den Cube am index i zu und setzen dessen position auf cubePos.
            cubes[i].transform.position = cubePos;
        }
    }
}
