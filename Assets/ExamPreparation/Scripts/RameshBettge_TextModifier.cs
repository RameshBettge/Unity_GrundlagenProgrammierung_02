using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RameshBettge_TextModifier : MonoBehaviour
{
    public int numBananas = 2;

    public int numApples = 1;

    public Text messageDisplay;

    void Update()
    {
        int sumFruits = numBananas + numApples;

        // Bananas: 2, Apples: 1, Sum = 3
        messageDisplay.text = "Bananas: " + numBananas.ToString() + ", Apples: " + numApples.ToString() + ", Sum = " + sumFruits.ToString();
    }
}
