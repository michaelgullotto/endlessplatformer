using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoretext : MonoBehaviour
{
    

    void Start()
    {
   
    }

    private void Update()
    {


        GetComponent<TMPro.TextMeshProUGUI>().text = Scoresave.score.ToString() + ":Score";

    }


}
