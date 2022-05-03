using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text currentScoreTxt;
    private int currentScore;
    public Text BestScoreTxt;
    private int bestScore;      

    public void SetScore(int value)
    {
        currentScore=value;
        currentScoreTxt.text = "Score : " + currentScore;
        PlayerPrefs.SetInt("Score", currentScore);
        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            BestScoreTxt.text = "Best Score : " + bestScore;
            PlayerPrefs.SetInt("Best Score", bestScore);
        }
    }
    public int GetScore()
    {
        return currentScore;
    }
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        BestScoreTxt.text = "Best Score : " + bestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
