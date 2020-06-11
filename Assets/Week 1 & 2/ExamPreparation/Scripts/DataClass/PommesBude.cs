using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PommesBude : MonoBehaviour
{
    public void ReceiveOrder(PommesBestellung bestellung)
    {
        if(bestellung.useMustard)
        {
            // Senf hinzu fügen
        }

        if (bestellung.useMajo)
        {
            // Majo hinzu fügen
        }

        if(bestellung.soda.Length > 0)
        {
            // Fügen wir bestellte Soda hinzu.
        }
    }
}
