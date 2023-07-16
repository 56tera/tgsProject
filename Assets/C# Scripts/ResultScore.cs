using System.Diagnostics;
using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class ResultScore : MonoBehaviour
{
    public Text ScoreText; 
    public int Score;
    RectTransform rb;
    private float time;
    private float y;
    private bool flag;

   // Start is called before the first frame update
   void Start()
   {
        Score = 0;
        ScoreText.text = "SCORE: " + Score;
        flag = false;

        rb = GetComponent<RectTransform>();
        y = rb.localPosition.y;
   }

   // Update is called once per frame
   void Update()
   {   
       if(Input.anyKeyDown){
            flag = true;
        }

        if(flag){
            if(Mathf.Abs(y - rb.localPosition.y) > 750){
                rb.localPosition += new Vector3(0, -0.3f, 0);
            }
            rb.localPosition += new Vector3(0, 0.3f, 0);
        }
   }
}
