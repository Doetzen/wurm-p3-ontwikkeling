using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipeTeleport : MonoBehaviour
{
    
    //fyjmenld: fuck you je mag er niet langs doos 

    public void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(3);
       
        
    }
}
