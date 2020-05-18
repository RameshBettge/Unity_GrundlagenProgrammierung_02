using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveDistance = 5;

    float startPosX;

    public float speed = 2;



    void Start()
    {
        startPosX = transform.position.x;
    }

    void Update()
    {
        // Wir rufen die Sinusfunktion auf, die Teil von der Klasse Mathf ist.
        // Als Parameter übergeben wir die Zeit. 
        //   Diese multiplizieren wir mit einer public variable, um die Geschwindigkeit zu steuern.
        // Die Funktion gibt uns eine Zahl zwischen 1 und -1 zurück.
        float sinusValue = Mathf.Sin(Time.time * speed);

        // Wir addieren 1 auf unsere sinusValue, damit wir im positiven bereich bleiben (0 bis 2)
        // Wir teilen das Ergebnis durch zwei, damit wir auf den Bereich 0 bis 1 kommen.
        // Wir benötigen einen Wert in diesem Bereich für unsere MapFrom01 Funktion.
        float sinus01 = (sinusValue + 1) / 2f;

        // Wir ziehen die moveDistance von unserer StartPosition ab und speichern das Ergebnis in eine variable namens newMin.
        float newMin = startPosX - moveDistance;
        // Wir addieren die moveDistance auf unsere StartPosition und speichern das Ergebnis in eine variable namens newMax.
        float newMax = startPosX + moveDistance;

        // Wir rufen unsere MapFrom01 Funktion auf und speichern das Ergebnis in eine neue variable.
        // als Parameter übergeben wir unseren sinus01 Wert, und den minimalWert und maximalWert;
        float newPosX =  MapFrom01(sinus01, newMin, newMax);

        // Wir erstellen einen neuen vektoren. Als X Wert geben wir unsere newPosX an.
        // Für den y- und z-wert übernehmen wir die Werte, die aktuell in unserer transform.position gespeichert sind.
        Vector3 newPosition = new Vector3(newPosX, transform.position.y, transform.position.z);

        // Wir kopieren die Werte von newPosition in unsere transform.position.
        // -> Das objekt bewegt sich
        transform.position = newPosition;
    }


    float MapFrom01(float value01, float newMinValue, float newMaxValue)
    {
        // Wir berechnen die Range zwischen min und max.
        float newRange = newMaxValue - newMinValue;
        // Wir multiplizieren value01 mit der new Range.
        float newValue= value01 * newRange; //  Ergebnis ist mindestens 0. Maximal newRange

        // Wir addieren auf die new Value unsere newMinValue.
        // Das Ergebnis wird niemals unter newValue sein.
        newValue += newMinValue;

        // Wir geben den Wert, der in newValue gespeichert ist, zurück.
        return newValue;
    }
}
