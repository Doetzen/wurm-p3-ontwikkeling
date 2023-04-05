using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipeTeleport : MonoBehaviour
{
    public BoxCollider fyjmenld;
    //fyjmenld: fuck you je mag er niet langs doos  
    private MouseLock mouseLock;

    public void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(3);
        Destroy(fyjmenld);
        mouseLock.isLocked = false;
    }
}
