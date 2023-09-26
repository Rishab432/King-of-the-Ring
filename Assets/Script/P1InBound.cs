using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInBounds : MonoBehaviour
{
    [SerializeField] private CircleCollider2D _ring;

    void OnCollisionExit(Collision _ring)
    {
        WinScreens.Instance.p2Win = true;
    }
}
