using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    //カウントダウンタイム
    public static float CountDownTime;

    //表示用テキストUI
    public Text TextCountDown;

    void Start()
    {
        CountDownTime = 30.0F;
    }

    void Update()
    {
        //カウントダウンタイムを整形して表示
        TextCountDown.text = String.Format("Time: {0:00.00}", CountDownTime);

        //経過時刻を引いていく
        CountDownTime -= Time.deltaTime;

        // 0.0秒以下になったらカウントダウンタイムを0.0で固定（止まったように見せる）
        if (CountDownTime <= 0.0F)
        {
            CountDownTime = 0.0F;
        }
    }
}