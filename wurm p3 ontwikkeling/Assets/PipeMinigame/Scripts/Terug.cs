using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Terug : MonoBehaviour
{
    
    public void Poof()
    {
        SceneManager.UnloadSceneAsync(3);
        

    }
}

  
