using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreens: MonoBehaviour
{
    public static WinScreens Instance;
    public GameObject p1WinMenu, p2WinMenu;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        p1WinMenu.SetActive(false);
        p2WinMenu.SetActive(false);
    }

    public void GameFinished()
    {
        if (true)
        {
            p1WinMenu.SetActive(true);
        }
        else if (true)
        {
            p2WinMenu.SetActive(true);
        }
        Time.timeScale = 0f;
    }

    public void toMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
