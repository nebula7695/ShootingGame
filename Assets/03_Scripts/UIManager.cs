using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text currentScoreTxt;
    private int currentScore;
    public Text BestScoreTxt;
    private int bestScore;
    private void Start()
    {
        currentScore = PlayerPrefs.GetInt("Score", 0);
        currentScoreTxt.text = "Score " + currentScore;
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        BestScoreTxt.text = "Best Score " + bestScore;
    }
    public void BtnStart(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
