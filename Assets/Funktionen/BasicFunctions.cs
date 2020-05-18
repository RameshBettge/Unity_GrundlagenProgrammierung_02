using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicFunctions : MonoBehaviour
{
    // - Was ist eine Funktion?
    // Sie ist wiederverwendbar
    // Sie kann von woanders aufgerufen werden
    // Sie beinhaltet code
    // Bestandteil von einer Klasse.



   

    void SetPosition()
    {
        transform.position = new Vector3(1, 0, 0);

    }

    // - Was sind die Vorteile von Funktionen?
    // Wenn wir code mehrmals verwenden möchten, können wir eine einzige Funktion erstellen und diese an mehreren Stellen aufrufen.
    // Die Unterteilung von Code in mehrere Funktionen macht den code lesbarer
    // Wir brauchen unbedingt funktionen, da sonst der Code nirgendwo ausgeführt wird.


    // - Aus welchen Teilen besteht eine Funktion (4)?
    // Rückgabetyp (was die Funktion zurück gibt)
    // Ein beliebiger Name (groß geschrieben. Sollte gut beschreiben, was die Funktion tut)
    // Runde Klammern, in denen die Parameter definiert werden (das, was in die Funktion hinein gegeben wird). 
    //   Zuerst wird der parameter Typ definiert, dann der name.
    //   Mehrere Parameter werden durch Kommas getrennt.
    // Der Function Body (der code, der ausgeführt wird). Wird IMMER mit geschweiften Klammern begrenzt




    int AddNumbers(int a, int b)
    {
        int sum = a + b;

        return sum;
    }

    public float mapValue = 1;
    public float newMin = 20;
    public float newMax = 25;

    void Start()
    {
        int addedNumbers = AddNumbers(1, 2);

        //print(addedNumbers);

    }

    private void Update()
    {
        print( MapFrom01(mapValue, newMin, newMax) );
        // print( 20 )
    }

    float MapFrom01(float value, float newMinValue, float newMaxValue)
    {
        float newRange = newMaxValue - newMinValue; 
        value = value * newRange; // mindestens 0. Maximal newRange (hier: 5)
        value += newMinValue; 

        return value;
    }

    // - Wie rufen wir Funktionen auf?
    // Funktionsname(Parameter1, Parameter2) - Die Anzahl und die typen der Parameter müssen überein stimmen.



}
