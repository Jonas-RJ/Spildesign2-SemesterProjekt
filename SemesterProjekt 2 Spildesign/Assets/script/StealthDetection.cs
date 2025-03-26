using UnityEngine;

public class StealthDetection : MonoBehaviour
{
    [SerializeField] private int PlayerPresentInCollision;
    [SerializeField] private float TimeToSeen;


    [SerializeField] private bool playerSpottedByEnemy;
    [SerializeField] private static bool alertOthersInMob;
    [SerializeField] private static bool isAlert;
    [SerializeField] private static bool isSuspicious;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeToSeen > 5)
        {
            alertOthersInMob = true;
            //implement all mobs chasing here
        }
        if (TimeToSeen < 3) 
        {
         isAlert = true;
            playerSpottedByEnemy = true;
            //implement individual looking/chasing behaviour here
        }
        if (TimeToSeen < 1) 
        {
            isSuspicious = true;
            // implement looking behaviour here
        }
        

    }


// vi bruger OnTriggerstay til at checke om playeren er i detection range, hvis playeren er, så incrementer vi en detection value med 5, som tillader at vi kan sætte alert status til chase.
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TimeToSeen += Time.deltaTime;
            PlayerPresentInCollision = 1;
        }
        if (PlayerPresentInCollision == 0 && TimeToSeen > 0) 
        { 
            TimeToSeen -= Time.deltaTime; 
        }
    }

    //playerPresentInCollision bruges som en primitiv detection method, der forhindrer tiden / detection score i at decrease unødvendigt. 
    private void OnTriggerExit(Collider other)
    {
        PlayerPresentInCollision = 0;
    }


    private void timerReset()
    {
    }

    private void changeToChase() 
    {
    
    }


    private void resetPatrol()
    {

    }


    private void alertOthers() 
    {
        
    }


    private void changeAlertStatus() 
    {
    
    }
}
