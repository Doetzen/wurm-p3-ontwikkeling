using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colllision : MonoBehaviour
{
    public Convo collisionConvo;
    public ConvoManager passOn;

    public void OnCollisionEnter(Collision collision)
    {
        passOn.conversation = collisionConvo;
        passOn.frederickStart = true;
    }
}
