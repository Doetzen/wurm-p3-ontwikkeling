using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportTerug : MonoBehaviour
{
    public GameObject player;
    public Transform spawn;
    public BoxCollider fyjmenld;
    public GameManager gm;

    private void Start()
    {
       
       
    }
    void Update()
    {
       
        Destroy(fyjmenld);
    }

    void Poof()
    {
        SceneManager.LoadScene(1);
    }
}
