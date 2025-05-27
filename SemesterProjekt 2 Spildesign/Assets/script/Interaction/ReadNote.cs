using UnityEngine;
using UnityEngine.UI;

public class ReadNote : MonoBehaviour
{

    public DialogueManager DM;
    DialogueTrigger DT;
    public Button ReadThis;



    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ReadThis.gameObject.SetActive(true);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            ReadThis.gameObject.SetActive(false);
            DM.CloseOnWalkaway();        
        }
    }
}
