using UnityEngine;
using UnityEngine.UI;

public class Eavesdropping : MonoBehaviour
{

    public DialogueManager DM;
    DialogueTrigger DT;
    public Button ListenIn;

    void Awake()
    {
    
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ListenIn.gameObject.SetActive(true);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            ListenIn.gameObject.SetActive(false);
            DM.CloseOnWalkaway();        
        }
    }



    public void OverHearConversation()
    {
        


    }


}
