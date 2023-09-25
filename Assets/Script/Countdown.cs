using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    [SerializeField] private TMP_Text _countdown_title;
    public static bool gameStart;
    
    void Start()
    {
        StartCoroutine(readySetGoTimer(1));
    }

    private IEnumerator readySetGoTimer(float wait)
    {
        gameStart = false;
        _countdown_title.text = "Ready";
        yield return new WaitForSeconds(wait);
        _countdown_title.text = "Set";
        yield return new WaitForSeconds(wait);
        _countdown_title.text = "Go";
        yield return new WaitForSeconds(wait);
        _countdown_title.text = "";
        gameStart = true;
    }
}
