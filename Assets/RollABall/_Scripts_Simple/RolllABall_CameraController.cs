using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Dieses Klasse sorgt dafür, dass die Kamera einen festen Abstand zum Spieler beibehält.
// Dafür muss das Script auf dem Kamera-Objekt liegen.
// Im Inspector muss das Spielerobjekt zugewiesen werden.
public class RolllABall_CameraController : MonoBehaviour
{
    // Referenz zum Spielerobjekt.
    // Muss im Inspector gefüllt werden.
    public GameObject player;

    // Variable vom Typ Vector3
    Vector3 offset;

    // Start wird einmalig ausgeführt, wenn das Spiel gestartet wird.
    void Start()
    {
        // Der Abstand vom Spieler zur Kamera hin wird ausgerechnet und in der offset variable gespeichert.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate wird jede Frame ausgeführt.
    // LateUpdate wird erst ausgeführt, wenn die Update auf jedem Objekt ausgeführt wurde.
    void LateUpdate()
    {
        // Wir rechnen aus, auf welcher position wir uns befinden müssen,
        //   damit der Abstand zum Spieler gleich bleibt.
        // Das Ergebnis speichern wir in eine Variable namens newPosition.
        Vector3 newPosition = player.transform.position + offset;

        // Wir setzen unsere position auf den Wert, den wir in newPosition gespeichert haben.
        transform.position = newPosition;
    }
}
