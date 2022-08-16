using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTeleport : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnClicked += Teleport;

    }
    private void OnDisable()
    {
        EventManager.OnClicked -= Teleport;
    }

    private void Teleport()
    {
        transform.position = new Vector3(0, 6, 0);
    }
}
