using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("FightScene");
    }
    
    public void ToSettingsMenu()
    {
        SceneManger.LoadScene("SettingsMenu");
    }
    
    public void ToMainMenu()
    {
        SceneManger.LoadScene("MainMenu");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
