using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    LevelManager levelManager;
    private void Awake()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    public void ChangeSene(string scene)
    {
        if (levelManager == null)
        {
            print("level Manager not found");
            return;
        }

        levelManager.LoadScene(scene);
    }
}
