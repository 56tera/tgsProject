using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Combo : MonoBehaviour
{
    public static int TotalCombo;

    public Text TextCombo;

    void Start()
    {
        TotalCombo = 0;
    }

    void Update()
    {
        TextCombo.text = String.Format(TotalCombo.ToString() + "Combo");

        if (Input.GetKeyDown(KeyCode.X))
        {
            TotalCombo++;
            
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.X))
        {
            TotalCombo = 0;
        }
    }
}