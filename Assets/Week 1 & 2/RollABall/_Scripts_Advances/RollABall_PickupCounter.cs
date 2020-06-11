using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollABall_PickupCounter : MonoBehaviour
{
    int numCollectedPickups;

    int maxPickups;

    public Text scoreText;
    public Text winText;

    private void Start()
    {
        maxPickups = FindObjectsOfType<RollABall_Pickup>().Length;

        winText.enabled = false;

        UpdateScoreText();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<RollABall_Pickup>())
        {
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            OnPickedUp();
        }
    }

    void OnPickedUp()
    {
        numCollectedPickups++;

        UpdateScoreText();

        if (numCollectedPickups == maxPickups)
        {
            scoreText.enabled = false;
            winText.enabled = true;
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Count: " + numCollectedPickups;
    }
}
