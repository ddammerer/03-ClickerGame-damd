
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    private int currentScore = 0;
    public void AddPoint() {
        currentScore++;
        scoreText.text = "Points: " + currentScore;
        Debug.Log("Score: " + currentScore);
    }

    public void SaveScore() {
        PlayerPrefs.SetInt("score", currentScore);
        PlayerPrefs.Save();
    }

    public void LoadScore() {
        currentScore = PlayerPrefs.GetInt("score", 0);
        scoreText.text = "Points: " + currentScore;
    }

}