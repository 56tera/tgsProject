using System.Diagnostics;
using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Debug = UnityEngine.Debug;


public class resultTextSetting : MonoBehaviour
{

    RectTransform rb;
    private float y;
    private bool flag;
    
    void Start()
    {
        rb = GetComponent<RectTransform>();
        y = rb.localPosition.y;
        flag = false;
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
