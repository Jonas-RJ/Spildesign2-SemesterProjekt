using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue; //A variable for the dialogue object that we want to have.
    

    public void TriggerDialogue()
    {
        //Finding out DialogueManager and passing in our dialogue object, so that is the dialogue being played
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue); //Maybe implement a Singleton pattern here.
    }
}
