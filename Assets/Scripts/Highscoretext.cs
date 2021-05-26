using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscoretext : MonoBehaviour
{
    
    

    void Start()
    {
       
    }

    private void Update()
    {


        GetComponent<TMPro.TextMeshProUGUI>().text = Scoresave.Highscore.ToString() + ":HighScore";

    }


}

