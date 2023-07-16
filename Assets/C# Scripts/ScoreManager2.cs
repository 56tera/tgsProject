using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager2 : SingletonMonoBehaviour<ScoreManager2>
{
    int CountCombo;
    float time;
    public int score;

    void Start()
    {
        score = 0;
         DontDestroyOnLoad(this.gameObject);
    }

    void update()
    {
        time = time + Time.deltaTime;
    }
    public void AddScore(float time)
    {
        score += 1000 + (int)(50-time);
    }

    public int GetScore() {
        return score;
    }
}