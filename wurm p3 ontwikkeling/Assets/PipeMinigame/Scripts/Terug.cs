using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Terug : MonoBehaviour
{
    public Transform spawn
        ;
    public GameObject player;
    public bool scene;
    public void Poof()
    {
        SceneManager.LoadScene(1);
        scene = true;
        DontDestroyOnLoad(spawn);
    }

    public void Start()
    {
        if (scene == true)
        {
            player.transform.position = spawn.position;
        }
        
    }

}
