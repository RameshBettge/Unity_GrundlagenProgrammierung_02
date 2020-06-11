using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exam_XP_Giver : MonoBehaviour
{
    int xpToGive = 10;


    private void OnDestroy()
    {
        Exam_PlayerXP playerXP = FindObjectOfType<Exam_PlayerXP>();    

        if(playerXP != null)
        {
            // -- Verwenden von Funktionen
            //playerXP.experience += 2000;
            playerXP.SetLevel(2);
            print(playerXP.GetLevel());


            // -- Verwenden von einer Property
            playerXP.Level = 5;
            print(playerXP.Level);
        }
    }
}
