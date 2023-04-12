using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorParcour : MonoBehaviour
{
    private bool gameEnded;
    public string nextLevelName;

    public void WinLevel()
    {
        Debug.Log("you win");
        SceneManager.LoadScene(2);
    }
}
