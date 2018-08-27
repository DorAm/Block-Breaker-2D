using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class PlayerPrefs : MonoBehaviour {

    // Use this for initialization
    public Text scoreText;
    public Text levelText;
    public Text highScores;
    public Text userName;

    void Start()
    {
       updateScoreText();
       updatelevelText();
    }

    void updateHighScoresText()
    {
        highScores.text = UnityEngine.PlayerPrefs.GetString("highScores");
    }

    void updateScoreText()
    {
        scoreText.text = "Score: " + UnityEngine.PlayerPrefs.GetInt("score");
    }

    void updatelevelText()
    {
        levelText.text = "Level: " + UnityEngine.PlayerPrefs.GetInt("level");
    }

    public void AddScore(int newScoreValue)
    {
        UnityEngine.PlayerPrefs.SetInt("score", UnityEngine.PlayerPrefs.GetInt("score") + newScoreValue);
        updateScoreText();
    }

    public void AddToHighScores()
    {
        UnityEngine.PlayerPrefs.SetString("highScores", "HighScores:\n" + UnityEngine.PlayerPrefs.GetInt("highScores") + UnityEngine.PlayerPrefs.GetString("name") + ": " + UnityEngine.PlayerPrefs.GetInt("score"));
        updateHighScoresText();
    }


    public void IncLevel()
    {
        UnityEngine.PlayerPrefs.SetInt("level", UnityEngine.PlayerPrefs.GetInt("level") + 1);
        updatelevelText();
    }
}
