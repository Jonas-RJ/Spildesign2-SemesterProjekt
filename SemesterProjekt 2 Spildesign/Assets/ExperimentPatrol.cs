using System.Collections;
using UnityEngine;

public class ExperimentPatrol : MonoBehaviour
{
    public Patrol PS;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            print("entered trigger");

            PS.IncreaseTargetInt();
            PS.StartCoroutine("Stop");


        }
        PS.mAgent.SetDestination(PS.patrolPoints[PS.targetPoint].position);
    }

}
