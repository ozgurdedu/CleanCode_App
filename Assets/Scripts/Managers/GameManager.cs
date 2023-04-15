using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cleancode_App.Abstracts.Utils;


public class GameManager : Singleton<GameManager>
{
    public event System.Action OnGameOver;
    public event System.Action OnMissionSucceed;


    private void Awake()
    {
        SingletonFunction(this);
    }

    public void GameOver()
    {
        OnGameOver?.Invoke();
    }

    public void MissionSucceed()
    {
        OnMissionSucceed?.Invoke();;
    }

    public void LoadLevelScene(int levelIndex = 0)
    {
        StartCoroutine(LoadLevenSceneAsync(levelIndex));
    }


    private IEnumerator LoadLevenSceneAsync(int levelIndex)
    {
        yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
    }

    
    public void LoadMenuScene()
    {
        StartCoroutine(LoadMenuSceneAsync());
    }

    private IEnumerator LoadMenuSceneAsync()
    {
        yield return SceneManager.LoadSceneAsync("Menu");
    }
    
    public void Exit()
    {
        Debug.Log("GOOOD BYE!");
        Application.Quit();
    }

}
