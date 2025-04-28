using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.Rendering;


public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue; //A variable for the dialogue object that we want to have.
    public GameObject startButton;
    

    public void TriggerDialogue()
    {
        //Finding our DialogueManager and passing in our dialogue object, so that is the dialogue being played
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue); //Maybe implement a Singleton pattern here.
    }

    public void RemoveStartGameButton()
    {
        startButton.SetActive(false);
    }
}
