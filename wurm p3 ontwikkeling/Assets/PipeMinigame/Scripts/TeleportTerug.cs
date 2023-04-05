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

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene(1);
        player.transform.position = spawn.position;
        Destroy(fyjmenld);
    }

    void Poof()
    {
        SceneManager.LoadScene(1);
    }
}
