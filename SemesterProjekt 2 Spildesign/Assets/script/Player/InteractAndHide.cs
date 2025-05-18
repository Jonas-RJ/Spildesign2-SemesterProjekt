using UnityEngine;
using UnityEngine.UI;

public class InteractAndHide : MonoBehaviour
{
private int hideUnhide;
public GameObject playerObject;
public MeshRenderer player;
public SpriteRenderer barrel;
    public Button Hide;
    private Button Interact;
     // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
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



    public void Hiding()
    {


        if (hideUnhide > 1)
        {
            player.enabled = false;
            barrel.enabled = true;
            hideUnhide++;
            playerObject.tag = "PlayerHiding";
            

            
        }
        else
        {
            player.enabled = true;
            barrel.enabled = false;
            hideUnhide--;

            //IMPLEMENT CEASE MOVEMENT, CHANGE SPRITE, STOP CHASE, CHANGE PLAYER LAYER FOR DETECTION

        }

    }

    public void stopHide(){}
}
