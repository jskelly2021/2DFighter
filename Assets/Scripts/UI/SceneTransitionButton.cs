
using UnityEngine;

public class SceneTransitionButton : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        GameManager.Instance.ChangeScene(sceneName, true);
    }

    public void UnloadScene(string sceneName)
    {
        GameManager.Instance.ChangeScene(sceneName, false);
    }

    public void LoadNextScene()
    {
        GameManager.Instance.LoadNextScene();
    }
    
    public void QuitGame()
    {
        GameManager.Instance.QuitGame();
    }
}
