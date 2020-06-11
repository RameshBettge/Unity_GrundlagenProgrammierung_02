using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
    public Text inputDisplay;

    private void Update()
    {
        //[1, -1]

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        string output = "[" + x + ", " + y + "]";

        inputDisplay.text = output;
    }
}
