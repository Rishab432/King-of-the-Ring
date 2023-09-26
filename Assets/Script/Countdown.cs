using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Countdown : MonoBehaviour
{
    public static Countdown Instance;
    [SerializeField] private TMP_Text _countdown_title;
    public static bool gameStart;

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

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Scene Loaded" + scene.name);
        if (scene.name == "FightScene")
        {
            Debug.Log("this scene has been loaded");
            StartCoroutine(readySetGoTimer(1));
        }
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private IEnumerator readySetGoTimer(float wait)
    {
        PauseMenu.Instance.pauseButton.SetActive(false);
        gameStart = false;
        _countdown_title.text = "Ready";
        yield return new WaitForSeconds(wait);
        _countdown_title.text = "Set";
        yield return new WaitForSeconds(wait);
        _countdown_title.text = "Go!";
        yield return new WaitForSeconds(wait);
        _countdown_title.text = "";
        PauseMenu.Instance.pauseButton.SetActive(true);
        gameStart = true;
    }
}
