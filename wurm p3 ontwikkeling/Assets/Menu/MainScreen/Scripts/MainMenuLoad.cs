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

    public void ResetSave()
    {
        PlayerPrefs.SetInt("levelsDone", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
