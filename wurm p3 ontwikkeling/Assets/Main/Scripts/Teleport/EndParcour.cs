using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndParcour : MonoBehaviour
{
    public string nextLevelName;
    public int levelNumberSave;
    
    private void OnCollisionEnter(Collision collision)
    {   
        if(PlayerPrefs.GetInt("levelsDone") < levelNumberSave)
        {
            PlayerPrefs.SetInt("levelsDone", levelNumberSave);
        }

        {
            SceneManager.LoadScene(2);
        }
    }
}