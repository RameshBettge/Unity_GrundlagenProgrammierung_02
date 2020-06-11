using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Benötigt, um auf die Text komponente zu benutzen (da diese zum UI gehört)
using UnityEngine.UI;

// Das ist eine Klasse namens RollABall_UI, welche von MonoBehaviour abstammt.
public class RollABall_UI : MonoBehaviour
{
    // Referenz zu einer Text Komponente.
    // Diese können wir im Inspector füllen.
    // Das können wir tun, da sie public ist.
    public Text countText;

    // Das gleiche wie bei countText
    public Text winText;

    // variable vom typ ganzzahl wird definiert.
    int count;

    public int winCount = 5;

    // Wird einmal ausgeführt, wenn wir den Playmode betreten.
    // Wird auch ausgeführt wenn das Objekt neu estellt wird, während das Spiel läuft.
    void Start()
    {
        // Der Wert 0 wird in die variable count geschrieben.
        count = 0;

        // Die Funktion SetCountText wird ausgeführt.
        SetCountText();

        // Wir greifen auf die string variable von winText zu und setzen diese auf einen leeren string.
        winText.text = "";
    }

    // Wird in der Frame aufgerufen, in der ein Collider einen trigger berührt, bzw. in der ein Trigger einen anderen berührt.
    // Als Parameter wird der getroffene collider übergeben.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pick Up")
        {
            // count variable wird um 1 erhöht.
            count = count + 1;
            // das pickup objekt wird aus gestellt
            other.gameObject.SetActive(false);
            // Die Funktion SetCountText wir ausgeführt.
            SetCountText();
        }

        // --- ALTERNATIVER ANSATZ:
        // 

        //RollABall_Pickup pickupComponent = other.gameObject.GetComponent<RollABall_Pickup>();

        //if (pickupComponent != null)
        //{
        //    pickupComponent.OnCollected();
        //}
    }

    // Setzt den text von CountText auf "Count: " + den Inhalt von unserer countVariable.
    // Falls count >= 12 ist, wird der text von winText auf "You Win!" gesetzt
    void SetCountText()
    {
        // Wir greifen auf den string namens text auf der countText-komponente zu.
        // in den string schreiben wir "Count: " und die Zahl, die in der count variable gespeichert ist.
        // ToString() wandelt den Zahlenwert in einen string um.
        countText.text = "Count: " + count.ToString();

        // Es wird abgefragt, ob der Zähler, mindestens 12 ist, falls ja ...
        if (count >= winCount)
        {
            // ... wir greifen über unsere Referenz auf eine Text-komponente zu. 
            // Teil dieser Text-Komponente ist ein string namens text. 
            // Diesen string setzen wir auf den Wert "You Win!"
            winText.text = "You Win!";
        }
    }
}
