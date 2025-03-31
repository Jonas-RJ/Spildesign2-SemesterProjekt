using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    

    public void TriggerDialogue()
    {
        //Finding out DialogueManager
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue); //Maybe implement a Singleton pattern here.
    }
}
