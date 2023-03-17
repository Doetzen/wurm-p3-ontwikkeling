using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoodGaan: MonoBehaviour
{
    public GameObject player;
    public Transform spawnPoint;

    public void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = spawnPoint.position;
        }
    }

}
