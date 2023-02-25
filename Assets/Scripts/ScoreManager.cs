using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score, randomScore;

    public Text scoreUI;

    private void Update()
    {
        randomScore = Random.Range(0, 10);

        AddScore(score);
    }
    public void AddScore(int newScore)
    {
        newScore += randomScore;
        scoreUI.text = "" + newScore;
    }
}
