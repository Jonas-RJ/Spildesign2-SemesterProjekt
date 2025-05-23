using UnityEngine;

public class TriggerHeadNorth : MonoBehaviour
{
   public GameObject headNorthCanvas;
   
   public DialogueTrigger trigger;

   public GameObject triggerHeadNorth;

   public void OnTriggerEnter(Collider other)
   {
       if (other.tag == "Player")
       {
           trigger.TriggerDialogue();
           //headNorthCanvas.gameObject.SetActive(true);
       }
   }

   public void OnTriggerExit(Collider other)
   {
       if (other.tag == "Player")
       {
           triggerHeadNorth.gameObject.SetActive(false);
       }
   }
   
   // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
