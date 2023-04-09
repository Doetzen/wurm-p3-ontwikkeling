using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DoodGaan: MonoBehaviour
{
    public GameObject player, cam;
    public Transform spawnPoint;
    public AudioSource dood;

    public void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            player.transform.position = spawnPoint.position;
            player.transform.eulerAngles = new Vector3(0, -90, 0);
            cam.transform.rotation = quaternion.Euler (0, 0, 0);
            dood.Play();
        }
    }
    
}
