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
    public AudioSource voiceSource;
    public Button buttonA, buttonB; 
   
 


    public void Start()
    {
       conversationPlus= 0;
    }

    public void Update()
    {
        if (frederickStart == true)
        {
            text.gameObject.SetActive(true);
            text.text = conversation.convoText[conversationPlus];
            if (Input.GetKeyDown(KeyCode.Space))
            {
                choiceA.text = conversation.answers[0];
                choiceB.text = conversation.answers[1];
            }
            
        }

        if (beginStart == true)
        {
            moveOff.movementOff = false;
            text.text = conversation.convoText[conversationPlus];
            /*
             *voiceSource.clip = conversation.voiceOvers[conversationPlus];
             *voiceSource.Play();
             *ik kreeg errors
           */ 
            if (Input.GetKeyDown(KeyCode.Space)) 
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
                    conversationPlus = 0;

                }
                
            }
            
        }
    }

    public void ChoiceA()
    {
        if (conversationPlus < conversation.convoText.Length - 2)
        {
            conversationPlus = (conversationPlus * 2) + 1;

        }
        else 
        {
            print("aaaa");
            choiceB.gameObject.SetActive(false);

        }
      
            
    }

    public void ChoiceB()
    {
        if (conversationPlus < conversation.convoText.Length - 2)
        {
            conversationPlus = (conversationPlus * 2) + 2;

        }
       else
       {
            print("bbbb");
            choiceB.gameObject.SetActive(false);
       }
    }


}
