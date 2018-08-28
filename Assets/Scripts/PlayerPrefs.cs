using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class PlayerPrefs : MonoBehaviour {

    // Use this for initialization
    [SerializeField] private Text scoreText;
    [SerializeField] private Text levelText;
    [SerializeField] private Text highScores;
    [SerializeField] private Text userName;

    void Start()
    {
       updateScoreText();
       updatelevelText();
        if (highScores)
        {
            updateHighScoresText();
        }
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
        string newScore = UnityEngine.PlayerPrefs.GetString("name") + ": " + UnityEngine.PlayerPrefs.GetInt("score") + Environment.NewLine;
        Debug.Log(newScore);
        
        var test = UnityEngine.PlayerPrefs.GetString("highScores");
        test +=  newScore;
        UnityEngine.PlayerPrefs.SetString("highScores", test);
        updateHighScoresText();
    }


    public void IncLevel()
    {
        UnityEngine.PlayerPrefs.SetInt("level", UnityEngine.PlayerPrefs.GetInt("level") + 1);
        updatelevelText();
    }
}
