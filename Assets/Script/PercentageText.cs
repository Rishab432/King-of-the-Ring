using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PercentageText : MonoBehaviour
{
    [SerializeField] private TMP_Text _p1_title, _p2_title;

    void Update()
    {
        _p1_title.text = Attack1.Instance.knockback1.ToString() + "%";
        _p2_title.text = Attack2.Instance.knockback2.ToString() + "%";

    }
}
