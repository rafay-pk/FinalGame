using UnityEngine;

public class SceneProxy : MonoBehaviour
{
    public void Restart() => SceneSwitch.Instance.RestartLevel();
    public void MainMenu() => SceneSwitch.Instance.MainMenu();
    public void Quit() => SceneSwitch.Instance.QuitGame();
    public void LoadLevel(int i) => SceneSwitch.Instance.LoadLevel(i);
    public void SetDifficulty(int i)
    {
        SceneSwitch.Instance.difficulty = i;
    }
    public void NextLevel()
    {
        SceneSwitch.Instance.LoadLevel(SceneSwitch.Instance.CurrentLevel + 1);
    }
}
