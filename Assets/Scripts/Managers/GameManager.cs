
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {  get; private set; }

    public AudioManager AudioManager { get; private set; }
    public LevelManager LevelManager { get; private set; }
    public PlayerManager PlayerManager { get; private set; }

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
        AudioManager = GameObject.FindObjectOfType<AudioManager>();
        LevelManager = GameObject.FindObjectOfType<LevelManager>();
        PlayerManager = GameObject.FindObjectOfType<PlayerManager>();
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
