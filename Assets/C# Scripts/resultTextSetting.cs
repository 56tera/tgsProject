using System.Diagnostics;
using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;


public class resultTextSetting : MonoBehaviour
{

    RectTransform rb;
    private float time;
    private float y;
    
    void Start()
    {
        rb = GetComponent<RectTransform>();
        time = 0;
        y = rb.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {

        
        time += Time.deltaTime;
        if (time < 2.0f) {
            rb.localPosition += new Vector3(0, 0, 0);
        }
        else{
            if(Mathf.Abs(y - rb.localPosition.y) > 800){
                rb.localPosition += new Vector3(0, -1.0f, 0);
            }
            rb.localPosition += new Vector3(0, 1.0f, 0);
        }
        Debug.Log($"{rb.localPosition.y}");
        Debug.Log($"diff: {Mathf.Abs(y - rb.localPosition.y)}");
    }
}
