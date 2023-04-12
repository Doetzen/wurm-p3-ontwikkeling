using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndParcour : MonoBehaviour
{
    private bool gameEnded;
    public string nextLevelName;
    public int levelNumberSave;
    
    private void OnCollisionEnter(Collision collision)
    {   
        if(PlayerPrefs.GetInt("levelsDone") < levelNumberSave)
        {
            PlayerPrefs.SetInt("levelsDone", levelNumberSave);
        }

        if (nextLevelName != "")
        {
            SceneManager.LoadScene(2);
        }
        gameEnded = true;
    }
}