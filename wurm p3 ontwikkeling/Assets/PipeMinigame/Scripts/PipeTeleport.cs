using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipeTeleport : MonoBehaviour
{
    public GameObject fyjmenld;
    public GameObject pipeTel;
   
    private void OnMouseDown()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Additive);
        Destroy(fyjmenld);
        Destroy(pipeTel);
    }
}
