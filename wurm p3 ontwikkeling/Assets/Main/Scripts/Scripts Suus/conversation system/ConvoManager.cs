using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEngine.UIElements;

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
    public GameObject boom;
   
 


    public void Start()
    {
       conversationPlus= 0;
    }

    public void Update()
    {
        if (frederickStart == true)
        {
            moveOff.movementOff = false;
            text.gameObject.SetActive(true);
            text.text = conversation.convoText[conversationPlus];
            if (Input.GetKeyDown(KeyCode.Space))
            {
                choiceA.text = conversation.answers[1];
                choiceB.text = conversation.answers[0];
               Destroy(boom);
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
        if (conversationPlus < conversation.convoText.Length - 3)
        {
            conversationPlus = (conversationPlus * 2) + 1;
            choiceA.text = conversation.answers[2];
            choiceB.gameObject.SetActive(false);

        }
        else 
        {
            frederickStart = false;
            text.gameObject.SetActive(false);
            choiceA.gameObject.SetActive(false);
            moveOff.movementOff = true;

        }


    }

    public void ChoiceB()
    {
        if (conversationPlus < conversation.convoText.Length - 4)
        {
            conversationPlus = (conversationPlus * 2) + 2;
            choiceA.gameObject.SetActive(false);


        }
       else
       {   
            frederickStart = false;
            moveOff.movementOff = true;
            choiceB.gameObject.SetActive(false); 
            text.gameObject.SetActive(false);
            choiceA.gameObject.SetActive(false);
            SceneManager.LoadScene(4);

        }
    }


}
