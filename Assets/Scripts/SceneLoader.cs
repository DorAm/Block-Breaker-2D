using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private const int FIRST_SCENE_ID = 0;

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(FIRST_SCENE_ID);
    }

    public void LoadLeaderBoard()
    {
        SceneManager.LoadScene("LeaderBoard");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}