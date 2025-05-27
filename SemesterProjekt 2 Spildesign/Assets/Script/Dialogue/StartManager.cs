using UnityEngine;

public class StartManager : MonoBehaviour
{
    public DialogueTrigger DT;
    public AudioController AC;
    public BackgroundManager BM;
    //public DialogueManager DialogueManager;
    //public Dialogue dialogue;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DT.TriggerDialogue();
        DT.RemoveStartGameButton();
        AC.StartCutSceneMusic();
        BM.AddOneToCurrentSlide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
