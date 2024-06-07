using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : Singleton<SceneLoadManager>
{
    public void LoadMainScene()
    {
        LoadScene("1_MainScene");
    }

    public void LoadIntroScene()
    {
        LoadScene("2_IntroScene");
    }

    public void LoadGameScene()
    {
        LoadScene("3_GameScene");
    }

    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
