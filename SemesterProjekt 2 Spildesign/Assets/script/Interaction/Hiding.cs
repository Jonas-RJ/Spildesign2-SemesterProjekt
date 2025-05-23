using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hiding : MonoBehaviour
{

    public bool isHiding = false;

    public Health HS;
    public StealthDetection SD;

    [Header("Player switches")]
    public MovementScript2 ms2;
    public Light playerLight;
    public SpriteRenderer CharSprite;
        public GameObject playerObject;
    public GameObject InteractionObject;
    public Rigidbody PlayerRB;
    public GameObject PlayerCam;


    


[Header("Barrel switches")]
    public Light barrelLight;
    private int hideUnhide = 0;
    public GameObject BoxCam;


    [Header("Button")]
    public Button HidingButton;
    public TextMeshProUGUI ButtonText;



    void OnTriggerStay(Collider PlayerCol)
    {
        if (PlayerCol.CompareTag("Player"))
        {

            HidingButton.gameObject.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            HidingButton.gameObject.SetActive(false);

        }
    }



    public void hidePlayer()
    {
        if (hideUnhide < 1)
        {
            //  playerObject.SetActive(false);
            barrelLight.enabled = true;
            playerLight.enabled = false;
            hideUnhide++;
            playerObject.tag = "PlayerHiding";
            InteractionObject.tag = "PlayerHiding";
            ms2.enabled = false;
            CharSprite.enabled = false;
            PlayerRB.isKinematic = true;
            ButtonText.text = "Stop Hiding";
            PlayerCam.SetActive(false);
            BoxCam.SetActive(true);
            HS.CanTakeDamage = false;
            isHiding = true;
        }
        else
        {
            barrelLight.enabled = false;
            playerLight.enabled = true;
            hideUnhide--;
            playerObject.tag = "Player";
            InteractionObject.tag = "Player";
            ms2.enabled = true;
            CharSprite.enabled = true;
            PlayerRB.isKinematic = false;
            ButtonText.text = "Hide";
            PlayerCam.SetActive(true);
            BoxCam.SetActive(false);
            HS.CanTakeDamage = true;
            isHiding = false;

        }
    }
}
