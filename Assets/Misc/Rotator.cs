using UnityEngine;
using System.Collections;

// Dies ist eine Klasse namens Rotator.
// Sie lässt das Objekt, auf dem sie sich befindet, kontinuierlich rotieren.
public class Rotator : MonoBehaviour
{
    // void Update wird einmal pro Frame aufgerufen.
    void Update()
    {
        // Es wird auf die eigene Transform-Komponente zugegriffen. 
        // Rotate() ist eine Funktion von unserer Transform. 
        // Die Funktion lässt unser Object rotieren.
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
