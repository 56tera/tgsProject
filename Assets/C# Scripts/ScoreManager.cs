using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static int CountScore;

    public static int CountCombo;

    public Text TextScore;

    // Start is called before the first frame update
    void Start()
    {
        CountScore = 0;
        CountCombo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TextScore.text = String.Format("Score " + CountScore.ToString());

        if (Input.GetKeyDown(KeyCode.X))
        {
            CountCombo++;
            CountScore += 1000 + (CountCombo * 100);
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.X))
        {
            CountCombo = 0;
        }


    }
}
