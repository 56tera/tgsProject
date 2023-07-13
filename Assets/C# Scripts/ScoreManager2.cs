using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager2 : SingletonMonoBehaviour<ScoreManager2>
{

    public Text ScoreText;
    int CountCombo;
    float time;
    private int score = 0;

    void Start()
    {

        ScoreText.text = "SCORE:" + score;
    }

    void update()
    {
        time = time + Time.deltaTime;
    }
    public void AddScore()
    {
        score += 1000 + (CountCombo * 100);
        CountCombo++;

        ScoreText.text = "SCORE:" + score;
    }
}