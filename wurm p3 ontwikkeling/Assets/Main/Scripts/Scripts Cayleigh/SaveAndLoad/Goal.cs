using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public DoorParcour doorParcourScript;

    private void OnTriggerEnter(Collider other)
    {
        doorParcourScript.WinLevel();
    }
}

