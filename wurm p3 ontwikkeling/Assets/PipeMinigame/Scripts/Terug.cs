using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Terug : MonoBehaviour
{
    public Transform boops;
    public GameObject player;
    public bool scene;
    public void Poof()
    {
        SceneManager.LoadScene(1);
        scene = true;

    }

    public void Start()
    {
        if (scene == true)
        {
            player.transform.position = boops.position;
        }
        
    }

}
