using UnityEngine;

public class StealthDetection : MonoBehaviour
{

    [SerializeField] private float TimeToSeen;
    [SerializeField] private float Timer;
    [SerializeField] private bool enemySpotted;
    [SerializeField] private static bool alertMob;
    [SerializeField] private static bool isAlert;
    [SerializeField] private static bool isSuspicious;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //if timer > detectionlimit, alert = true

    }



    private void OnTriggerStay(Collider other)
    {
        // timer++
        //if 
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
