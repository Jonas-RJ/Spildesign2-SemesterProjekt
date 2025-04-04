using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable] //Makes this class' attributes visible in the inspector as it does not inherit from Monobehaviour.
public class Dialogue               //This whole class is used as an object, that we can pass into the DialogueManager, whenever we want to start a new dialogue. Therefore, this hosts all the info we need about a single dialogue.
{
    public string name; //So far this is the name of the NPC that we're talking with but this probably want be necessary in the start cutscenes anyway.
    
    [TextArea(3,10)] //Making the textbox(es) in Unity a better size
    public string[] sentences; //The sentences that we want to load into our queue from the DialogueManager
}
