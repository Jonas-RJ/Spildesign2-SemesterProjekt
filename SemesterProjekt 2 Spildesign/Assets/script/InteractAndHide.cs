using UnityEngine;
using UnityEngine.UI;

public class InteractAndHide : MonoBehaviour
{


    public Button Hide;
    private Button Interact;
     // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    void OnTriggerStay (Collider InteractableObject){

        if(InteractableObject.CompareTag("Hider"))
        {
                Hide.enabled = true;
        }

        if(InteractableObject.CompareTag("Interact")){
            Interact.enabled = true;
        }
    }
}
