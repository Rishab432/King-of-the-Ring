using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Countdown : MonoBehaviour
{
    public static Countdown Instance;
    public GameObject _text_holder;
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

    void Update()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "FightScene")
        {
            StartCoroutine(readySetGoTimer(1));
        }
    }

    //void OnEnable()
    //{
    //    SceneManager.sceneLoaded += OnSceneLoaded;
    //}

    //void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    //{
    //    if (scene.name == "FightScene")
    //    {
    //        StartCoroutine(readySetGoTimer(1));
    //    }
    //}

    //void OnDisable()
    //{
    //    SceneManager.sceneLoaded -= OnSceneLoaded;
    //}

    private IEnumerator readySetGoTimer(float wait)
    {
        _text_holder.SetActive(true);
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
        _text_holder.SetActive(false);
    }
}
