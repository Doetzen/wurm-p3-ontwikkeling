using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Conversation", menuName = "ConversationMenu", order = 1)]


public class Convo : ScriptableObject
{
    public string[] convoText;
    public string[] answers;
    public AudioClip[] voiceOvers;
    

}


