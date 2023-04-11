using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLoad : MonoBehaviour
{
   public void StartLevel(string levelName)
    {
       SceneManager.LoadScene(levelName);
    }
}
