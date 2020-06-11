using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Spawnt viele Instanzen von einem Prefab in einem Grid.
// Bewegt diese Instanzen wellenförmig in y-Richtung, basierend auf einer SinusFunktion
// Die Farbe der Instanzen ändert sich, basierend auf ihrer y-position.
public class SineGrid_02 : MonoBehaviour
{
    // Referenz zu einem GameObject (in unserem Fall der Default Cube)
    public GameObject prefab;

    // public ints, die dafür benutzt werden, die Größe des Arrays zu bestimmen.
    public int sizeX;
    public int sizeZ;

    // 2-dimensionaler GameObject Array
    GameObject[,] cubes;


    public float sineOffset = 0.2f;

    public Color downColor;
    public Color upColor;

    void Start()
    {
        // Wir erstellen einen neuen GameObject-Array mit den Größen, die wir mithilfe von sizeX & sizeZ eingestellt haben.
        cubes = new GameObject[sizeX, sizeZ];

        // Wir benutzen einen nested Loop, um unser grid aus instanziierten Prefabs zu erstellen.
        // Wir benutzen sizeX und sizeZ beim iterieren, da wir jeden Eintrag im Array füllen wollen.
        for (int x = 0; x < sizeX; x++)
        {
            for (int z = 0; z < sizeZ; z++)
            {
                // Wir rufen die Funktion InstantiatePrefab auf und übergeben x und z als parameter.
                InstantiatePrefab(x, z);
            }
        }
    }

    // Wird für jeden Eintrag im Array einmal aufgerufen.
    // Wird in der Start aufgerufen
    void InstantiatePrefab(int x, int z)
    {
        // Wir benutzen x und z um daraus einen neuen Vektor zu erstellen.
        Vector3 spawnPos = new Vector3(x, 0, z);

        // Wir benutzen den gerade erstellten spawnPos Vektor, um dort eine Instanz von unserem Prefab zu spawnen.
        // Wir geben Quaternion.identity als rotation an, da unsere instanz eine Rotation von (0, 0, 0) haben soll.
        // Eine Referenz zu der gespawnten Instanz wird in 'spawnedPrefab' gespeichert.
        GameObject spawnedPrefab = Instantiate(prefab, spawnPos, Quaternion.identity);

        // Die Referenz zur gespawnten Instanz wird in unserem cube-Array an der Stelle x,z gespeichert.
        cubes[x, z] = spawnedPrefab;
    }


    void Update()
    {
        // Wir verwenden genau die selben nested loops wie in der Start.
        // Wir rufen nun aber eine andere Funktion auf.
        for (int x = 0; x < sizeX; x++)
        {
            for (int z = 0; z < sizeZ; z++)
            {
                // Wir rufen die Funktion MoveCube auf und übergeben x und z als parameter.
                MoveCube(x, z);
            }
        }
    }


    // Wird für jeden Eintrag im Array einmal aufgerufen.
    // Wird in der Update aufgerufen
    void MoveCube(int x, int z)
    {
        // -- Sinus Berechnen

        // Wir berechnen einen Offset, der von Cube zu cube größer wird.
        // Dafür addieren wir den x- und z-index und multiplizieren diesen Wert mit einer float, wie wir public gemacht haben.
        float totalSineOffset = (x + z) * sineOffset;

        // Wir greifen auf die Sinusfunktion zu, die Teil vom struct Mathf ist.
        // Als parameter übergeben wir die Zeit + unseren totalSineOffset.
        float sine = Mathf.Sin(Time.time + totalSineOffset);


        // -- Sinus benutzen, um die Position zu verändern

        // Wir kopieren eine Referenz von cubes[x, z] in 'cubeToMove'.
        // Dies verändert nichts an der Funktionalität. Es erspart uns nur Schreibarbeit und macht den Code übersichtlicher
        GameObject cubeToMove = cubes[x, z];

        // Wir kopieren die Position von cubeToMove in einen Vector3
        Vector3 targetPos = cubeToMove.transform.position;
        // Wir setzen die y-komponente von targetPos auf sine;
        targetPos.y = sine;
        // Wir kopieren die Werte von targetPos in die Position von cubeToMove
        cubeToMove.transform.position = targetPos;



        // -- Sinus benutzen, um die Farbe zu verändern.

        // Wir mappen den Wertebereich vom Sinus (-1 bis 1) auf einen Bereich von 0 bis 1
        float mappedSine = (sine * 0.5f) + 0.5f;

        // Wir rufen die Funktion Lerp auf, die Teil der Color Klasse ist.
        // Lerp wird benutzt, um zwischen zwei Werten zu interpolieren.
        // Color.Lerp interpoliert zwischen zwei Farben.
        // Als dritten Parameter (t) übergeben wir unseren Sinus, den wir auf einen Bereich von 0 bis 1 gemappt haben.
        // -> Wir erhalten eine Farbe, die sich zwischen downColor und upColor befindet.
        Color targetColor = Color.Lerp(downColor, upColor, mappedSine);


        // Wir greifen auf die Renderer Komponente von cubeToMove zu.
        // Wir greifen auf das Farbe vom Material vom Renderer zu und setzen diese auf unsere gelerpte Farbe
        cubeToMove.GetComponent<Renderer>().material.color = targetColor;
    }
}
