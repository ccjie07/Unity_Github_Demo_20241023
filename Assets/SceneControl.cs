using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void LoadGame(string SceneName)
    {
        //�����޲z�� �� ���J����(�����W��);
        SceneManager.LoadScene(SceneName);
    }
    public void QuitGame()
    {
        //���ε{�� �� ���}();
        Application.Quit();
    }
}