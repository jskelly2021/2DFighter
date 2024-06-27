using System.Collections;
using System.Collections.Generic;
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

    public void QuitGame()
    {
        GameManager.Instance.QuitGame();
    }
}
