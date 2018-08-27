using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefs1 : MonoBehaviour {

    // Use this for initialization
    public Text scoreText;
    public Text levelText;
    public Text highScores;
    public Text userName;

    void Start()
    {
        updateScore();
        updatelevel();
    }

    void updateHighScores()
    {
        highScores.text = PlayerPrefs.GetString("highScores");
    }

    void updateScore()
    {
        scoreText.text = "Score: " + PlayerPrefs.GetInt("score");
    }

    void updatelevel()
    {
        levelText.text = "Level: " + PlayerPrefs.GetInt("level");
    }

    public void AddScore(int newScoreValue)
    {
        PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + newScoreValue);
        updateScore();
    }

    public void AddToHighScores()
    {
        PlayerPrefs.SetString("highScores", "HighScores:\n" + PlayerPrefs.GetInt("highScores") + PlayerPrefs.GetString("name") + ": " + PlayerPrefs.GetInt("score"));
        updateHighScores();
    }


    public void IncLevel()
    {
        PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
        updatelevel();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
