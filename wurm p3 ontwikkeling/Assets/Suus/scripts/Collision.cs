using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public BoxCollider deur;

    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        print("yess");
    }
}
