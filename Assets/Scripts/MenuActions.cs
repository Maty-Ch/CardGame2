using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActions : MonoBehaviour
{
    public void ChangeScene(string LevelName)
    {
        SceneManager.LoadScene(LevelName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
