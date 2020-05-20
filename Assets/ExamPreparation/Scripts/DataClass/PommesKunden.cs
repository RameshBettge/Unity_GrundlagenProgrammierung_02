using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PommesKunden : MonoBehaviour
{
    PommesBude bude;

    void Start()
    {
        PommesBestellung meineBestellung = new PommesBestellung();
        meineBestellung.numPommes = 3;
        meineBestellung.useMajo = true;
        meineBestellung.soda = "Cola";

        bude.ReceiveOrder(meineBestellung);
    }

}
