using UnityEngine;

public class StealthDetection : MonoBehaviour
{
    [SerializeField] private int PlayerPresentInCollision;
    [SerializeField] private float TimeToSeen;

    [SerializeField] public Patrol P2;
    [SerializeField] public Chase Chaser;
    [SerializeField] private bool playerSpottedByEnemy;
    [SerializeField] private static bool alertOthersInMob;
    [SerializeField] private  bool isAlert;
   // [SerializeField] private  bool isSuspicious;




    [SerializeField] private float DropChase;
    [SerializeField] private float ChaseTimerReset = 0;
    // Update is called once per frame
    void Update()
    {
        alertStatus();
        if (isAlert)
        {
            Chaser.startChase();
        }

        if (alertOthersInMob)
        {
            Chaser.startChase();
            print("start to chase");
        }
        resetPatrol();


        if (!isAlert)
        {
            P2.PatrolToNextPoint();
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

    private void alertStatus()
    {
        if (TimeToSeen > 5)
        {
            alertOthersInMob = true;
            //implement all mobs chasing here
        }
        if (TimeToSeen < 3 && TimeToSeen >= 1)
        {
            isAlert = true;

        }

        /*
        if (TimeToSeen < 1 && TimeToSeen > 0)
        {
            isSuspicious = true;
        }*/
    }
  


    public void resetPatrol()
    {
        if (isAlert && TimeToSeen <= 0)
        {
            ChaseTimerReset += Time.deltaTime;
            if (ChaseTimerReset >= DropChase)
            {
                isAlert = false;
                alertOthersInMob = false;
                ChaseTimerReset = 0;
                print("stop chasing");
            }
        }
    }
}
