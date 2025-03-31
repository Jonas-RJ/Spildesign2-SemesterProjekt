using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Dialogue
{
    public string name;
    
    [TextArea(3,10)] //Making the textbox(es) in Unity a better size
    public string[] sentences;
}
