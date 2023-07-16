using System.Diagnostics;
using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class ScoreGetter : MonoBehaviour
{
   public Text ScoreText; 
   public int Score;
   
   // Start is called before the first frame update
   void Start()
   {
        Score = 0;
        ScoreText.text = "SCORE: " + Score;
   }

   // Update is called once per frame
   void Update()
   {
       Score = ScoreManager2.Instance.GetScore();
       ScoreText.text = "SCORE: " + Score;
   }
}
