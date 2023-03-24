using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class ConvoManager : MonoBehaviour
{
    public Convo conversation;
    public TMP_Text text;
    public bool frederickStart;
    public bool beginStart;

    public void Start()
    {
        print("meeo");
    }

    public void Update()
    {
        if (frederickStart == true)
        {
            text.text = conversation.convoText[0];
        }

        if (beginStart == true)
        {
            text.text = conversation.convoText[0];
        }
    }

}
