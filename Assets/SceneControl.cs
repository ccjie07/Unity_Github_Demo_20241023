using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void LoadGame(string SceneName)
    {
        //場景管理器 的 載入場景(場景名稱);
        SceneManager.LoadScene(SceneName);
    }
    public void QuitGame()
    {
        //應用程式 的 離開();
        Application.Quit();
    }
}