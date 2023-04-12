using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_Button : MonoBehaviour
{
    public int neededLevels;
    private Button buttonElement;
    // Start is called before the first frame update
    void Start()
    {

        buttonElement =  GetComponent<Button>();
        if(PlayerPrefs.GetInt("levelsDone") >= neededLevels)
        {
            buttonElement.interactable = true;
        }
    }
}
