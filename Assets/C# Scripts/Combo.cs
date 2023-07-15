using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Combo : MonoBehaviour
{
    public static int CountCombo;

    public Text TextCombo;

    void Start()
    {
        CountCombo = 0;
    }

    void Update()
    {
        TextCombo.text = String.Format(CountCombo.ToString() + "Combo");

        if (Input.GetKeyDown(KeyCode.X))
        {
            CountCombo++;
            
        }
        else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.X))
        {
            CountCombo = 0;
        }
    }
}