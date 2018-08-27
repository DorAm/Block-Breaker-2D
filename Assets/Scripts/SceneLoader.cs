using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadNextScene()
    {
//        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
//       SceneManager.LoadScene(currentSceneIndex + 1);
        int nextLevel = UnityEngine.PlayerPrefs.GetInt("level") + 1;
        SceneManager.LoadScene(nextLevel);
      }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(Constants.Constants.MainMenu);
    }
    
    
    public void LoadLevelCompleted()
    {
        SceneManager.LoadScene(Constants.Constants.LevelCompleted);
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene(Constants.Constants.GameOver);
    }
    
    public void LoadLeaderBoard()
    {
        SceneManager.LoadScene(Constants.Constants.LeaderBoard);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}