using JetBrains.Annotations;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    //Setting up Array for Patrolpoints, and variables to access the patrolpoints, speed of the enemy and waiting time between points
    [SerializeField] public Transform[] patrolPoints;
    [SerializeField] private int targetPoint;
    [SerializeField] public float speed;
    [SerializeField] public float waitTime;

    public NavMeshAgent mAgent;
    //private float mDistance;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetPoint = 0;
        mAgent = GetComponent<NavMeshAgent>();
        mAgent.speed = speed;
        mAgent.isStopped = false;
    }

    

    // Update is called once per frame
    void Update()
    {
        Patrolling();
    }

    //Method for having the enemy patrol between set points in Array
    void Patrolling()
    { /*
        //If statement to check if we reached the desired patrolpoint, and cycles to the next point if true
        if (transform.position == patrolPoints[targetPoint].position)
        {
            IncreaseTargetInt();
            StartCoroutine("Stop");
        }
        //Makes the enemy move towards the patrol point
        //transform.position = Vector3.MoveTowards(transform.position, patrolPoints[targetPoint].position, speed * Time.deltaTime);
        //mDistance = Vector3.Distance(mAgent.transform.position, patrolPoints[targetPoint].position);
        mAgent.SetDestination(patrolPoints[targetPoint].position);
    
        */    
    }




    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PatrolPoint"))
        {
            print("entered trigger");

            IncreaseTargetInt();
            StartCoroutine("Stop");


        }
        mAgent.SetDestination(patrolPoints[targetPoint].position);

    }*/

    //Method for increasing the targetpoint number and resetting back to 0 if the threshold is reached
    public void IncreaseTargetInt()
    {
        targetPoint++;
        if (targetPoint >= patrolPoints.Length)
        {
            targetPoint = 0;
        }
        print("increment started");

    }

    //Coroutine for having the enemy stop on it's patrol for X amount of seconds
    public IEnumerator Stop()
    {
        mAgent.speed = 0;
        yield return new WaitForSeconds(waitTime);
        mAgent.speed = speed;
        yield return 0;
    }

    public void GoToPoint()
    {
        mAgent.SetDestination(patrolPoints[targetPoint].position);
    }
}
