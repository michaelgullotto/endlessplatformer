using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoresave : MonoBehaviour
{
    static public int score = 0 ;
    static public int Highscore =0 ;
    static public int savedscore = 0 ;
    void Start()
    {
        //Highscore = savedscore;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (score > Highscore)
        {
            Highscore = score;
        }
    }
}
