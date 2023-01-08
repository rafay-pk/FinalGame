using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : SingletonDontDestroy<SceneSwitch>
{
    public int difficulty;
    [SerializeField] private int levels;
    public int CurrentLevel { get; private set; }
    public bool IsLastLevel => CurrentLevel == levels;
    private void Awake()
    {
        Initialize();
        CurrentLevel = 1;
    }
    public void EndLevel()
    {
        SceneManager.LoadScene("LevelWin");
    }
    public void LoadLevel(int index)
    {
        CurrentLevel = index;
        RestartLevel();
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene($"Level_{CurrentLevel}");
    }
    public void MainMenu() => SceneManager.LoadScene("MainMenu");
    public void QuitGame() => Application.Quit();
}