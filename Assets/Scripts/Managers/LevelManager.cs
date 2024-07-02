
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        Debug.Log("Loading " + sceneName + " from sceneManager");
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        StartCoroutine(SetSceneActive(SceneManager.GetSceneByName(sceneName)));
    }

    public void UnloadScene(string sceneName)
    {
        Scene scene = SceneManager.GetSceneByName(sceneName);
   
        if (SceneManager.GetActiveScene() == scene)
        {
            Debug.Log(sceneName + " is still active");
            StartCoroutine(UnloadActiveScene(scene));
        }
        else
        {
            SceneManager.UnloadSceneAsync(sceneName);
            Debug.Log("Unloaded " + sceneName);
        }
    }

    private IEnumerator SetSceneActive(Scene scene)
    {
        while (!scene.isLoaded)
        {
            yield return null;
        }

        SceneManager.SetActiveScene(scene);
        Debug.Log(SceneManager.GetActiveScene().name + " is the active scene");
    }

    private IEnumerator UnloadActiveScene(Scene scene)
    {
        while (SceneManager.GetActiveScene() == scene)
        {
            yield return null;
        }

        SceneManager.UnloadSceneAsync(scene);
        Debug.Log(scene.name + " is unloaded");
    }
}
