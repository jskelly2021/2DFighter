
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {  get; private set; }

    public LevelManager levelManager { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
        
        InitManagers();
    }

    private void InitManagers()
    {
        levelManager = GameObject.FindFirstObjectByType<LevelManager>();
    }

    public void ChangeScene(string sceneName, bool load)
    {
        if (load)
            levelManager.LoadScene(sceneName);  
        else
            levelManager.UnloadScene(sceneName);
    }
    public void LoadNextScene()
    {
        levelManager.LoadNextScene();
    }

    public void PauseGame()
    {
        Time.timeScale = 0.0f;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1.0f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
