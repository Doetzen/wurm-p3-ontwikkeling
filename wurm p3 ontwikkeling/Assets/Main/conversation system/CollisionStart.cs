using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.ShaderData;

public class CollisionStart : MonoBehaviour
{
    public Convo convoStart;
    public ConvoManager startPassOn;

    public void OnCollisionEnter(Collision collision)
    {
        startPassOn.conversation = convoStart;
        startPassOn.beginStart = true;
    }

}
