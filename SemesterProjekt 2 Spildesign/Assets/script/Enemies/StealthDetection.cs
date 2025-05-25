using UnityEngine;

public class StealthDetection : MonoBehaviour
{
    [SerializeField] private int PlayerPresentInCollision;
    [SerializeField] public float TimeToSeen;

    [SerializeField] PursuedUI pui;
    [SerializeField] public Patrol P2;
    [SerializeField] public Chase Chaser;
    [SerializeField] private bool playerSpottedByEnemy;
    [SerializeField] private static bool alertOthersInMob;
    [SerializeField] public bool isAlert;

    [SerializeField] private float alertMin;
    [SerializeField] private float alertMax;
    [SerializeField] private float AllAlertMax;
    // [SerializeField] private  bool isSuspicious;

    public Hiding Hide;
public int nextPointer = 0;

    [SerializeField] private float DropChase;
    [SerializeField] private float ChaseTimerReset = 0;

    public void Awake()
    {
        Hide = FindAnyObjectByType<Hiding>();
        pui = FindObjectOfType<PursuedUI>();
    }

    // Update is called once per frame
    void Update()
    {
        alertStatus();
        if (isAlert)
        {
            Chaser.startChase();
            pui.Question();
        }

        if (alertOthersInMob)
        {
            Chaser.startChase();
            pui.Exclamation();
            print("start to chase");
        }
        resetPatrol();

        if (Hide.isHiding)
        {
            TimeToSeen = 0;
            isAlert = false;
            pui.Disable();
            alertOthersInMob = false;
            nextpoint();

        }

        if (!isAlert)
        {
            P2.PatrolToNextPoint();
        }
    }


    // vi bruger OnTriggerstay til at checke om playeren er i detection range, hvis playeren er, s� incrementer vi en detection value med 5, som tillader at vi kan s�tte alert status til chase.
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

    //playerPresentInCollision bruges som en primitiv detection method, der forhindrer tiden / detection score i at decrease un�dvendigt. 
    private void OnTriggerExit(Collider other)
    {
        PlayerPresentInCollision = 0;
    }

    private void alertStatus()
    {
        if (TimeToSeen > AllAlertMax)
        {
            alertOthersInMob = true;
            //implement all mobs chasing here
        }
        if (TimeToSeen < alertMax && TimeToSeen >= alertMin)
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
                pui.Disable();
                print("stop chasing");
            }
        }
    }


    public void SetTimerToZero()
    {
        isAlert = false;
        TimeToSeen = 0;
    }

    
    public void nextpoint()
    {

        if (nextPointer < 1)
        {
            P2.GotoNextPoint();
            print("Hiding, going to next point");
            nextPointer++;
        }
    }
}
