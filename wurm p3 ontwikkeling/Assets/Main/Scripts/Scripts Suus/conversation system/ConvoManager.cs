using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;
using UnityEngine.UI;
using Unity.VisualScripting;

public class ConvoManager : MonoBehaviour
{
    public Convo conversation;
    public TMP_Text text, choiceA, choiceB;
    public bool frederickStart;
    public bool beginStart;
    public int conversationPlus;
    public Movement moveOff;
 


    public void Start()
    {
       conversationPlus= 0;
    }

    public void Update()
    {
        if (frederickStart == true)
        {
            text.gameObject.SetActive(true);
            text.text = conversation.convoText[0];
            if (Input.GetKeyDown(KeyCode.Space))
            {
                choiceA.text = conversation.convoText[1];
                choiceB.text = conversation.convoText[2];
            }
        }

        if (beginStart == true)
        {
            moveOff.movementOff = false;
            text.text = conversation.convoText[conversationPlus];
            if(Input.GetKeyDown(KeyCode.Space)) 
            {
                if(conversationPlus < conversation.convoText.Length -1)
                {

                    conversationPlus += 1;
                }
                else
                {
                    moveOff.movementOff = true;
                    beginStart= false;
                    text.gameObject.SetActive(false);
                }
                
            }
            
        }
    }

}
