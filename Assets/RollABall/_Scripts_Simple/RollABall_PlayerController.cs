using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Dieses Script liest den Input des Spielers aus.
// Der Input wird benutzt, um das Objekt mit Hilfe des Rigidbodys zu bewegen 
//   (Physik wird simuliert, Kollisionen können stattfinden.)
public class RollABall_PlayerController : MonoBehaviour
{
    // Kann im Editor eingestellt werden. (public)
    // Eine variable vom Typ float mit dem Ausgangswert 5
    public float speed = 5;

    // Referenz zu einem Rigidbody
    Rigidbody rb;

    // Wird beim Start des Spiels einmalig ausgeführt
    // Wird auch ausgeführt, wenn das Objekt während des Spielens erzeugt wird.
    void Start()
    {
        // Wir suchen unseren eigenen Rigidbody und speichern die Referenz dazu
        rb = GetComponent<Rigidbody>();
    }

    // Wird immer wieder aufgerufen in kurzen festen intervallen (Framerate unabhängig)
    void FixedUpdate()
    {
        // Wir führen die Funktion Get Axis aus.
        // Diese Funktion ist Teil von der Klasse Input.
        // Wir übergeben den String "Horizontal" als Parameter, 
        //     denn wir möchten eine Achse namens Horizontal auslesen.
        //     Diese Achse ist von Unity vordefiniert (A&D, Pfeiltasten)
        // Das, was bei der Funktion raus kommt (ein Wert zwischen -1 und 1), speichern wir in eine neue variable namens moveHorizontal
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Das selbe wie bei der Zeile darüber, bloß mit einer Anderen Achse
        float moveVertical = Input.GetAxis("Vertical");

        // Um rb.AddForce zu benutzen, brauchen wir immer einen Vector3 (x, y, z).
        // Wir erstellen einen neuen vector aus unserem Input.
        // Auf der y Achse soll sich das object nicht bewegen, deshalb geben wir dort 0.0f.
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Wir greifen auf die Funktion AddForce von unserem referenzierten Rigidbody zu
        // Wir übergeben movement Parameter.
        // Vorher multiplizieren wir movement aber noch mit speed, damit wir einstellen können, wie schnell das Objekt beschleunigt.
        // Dem Rigidbody wird eine Kraft hinzugefügt - er wird 'angestoßen'.
        rb.AddForce(movement * speed);
    }



    // ---------- Pick Ups
    // Die folgende Funktion ermöglicht das Einsammeln von Pickups. 
    // Da sie nichts mit der Steuerung zu tun hat, kann es sinnvoll sein,
    //   diese Funktion in eine seperate Klasse zu packen. 
    //   Das ist meist besser für die Ordnung, ändert aber nichts an der Funktionalität.


    // Wird ausgeführt, wenn ein Trigger betreten wird, bzw. wenn ein Objekt unseren Trigger betritt.
    // Als Parameter wird der Funktion der Collider des anderen Objektes übergeben.
    void OnTriggerEnter(Collider other)
    {
        // Wir überprüfen, ob das andere gameobject das Tag "Pick Up" hat.
        if (other.gameObject.CompareTag("Pick Up"))
        {
            // Falls die If Abfrage true ergibt, greifen wir auf das andere GameObject zu und schalten es aus.
            other.gameObject.SetActive(false);
        }
    }
}
