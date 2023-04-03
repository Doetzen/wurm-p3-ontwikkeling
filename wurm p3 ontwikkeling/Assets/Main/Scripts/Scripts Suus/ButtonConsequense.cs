using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonConsequense : MonoBehaviour
{
   public void BackToStart()
    {
        SceneManager.LoadScene(0);
    }
}
