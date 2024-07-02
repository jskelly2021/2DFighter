
using UnityEngine;

public class SceneTransitionButton : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        GameManager.Instance.LevelManager.LoadScene(sceneName);
    }

    public void UnloadScene(string sceneName)
    {
        GameManager.Instance.LevelManager.UnloadScene(sceneName);
    }
    
    public void QuitGame()
    {
        GameManager.Instance.QuitGame();
    }
}
