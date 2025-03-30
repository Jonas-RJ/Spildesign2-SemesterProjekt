using JetBrains.Annotations;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Patrol : MonoBehaviour
{
    //Setting up Array for Patrolpoints, and variables to access the patrolpoints, speed of the enemy and waiting time between points
    [SerializeField] private Transform[] patrolPoints;
    private int targetPoint;
    [SerializeField] private float speed;
    [SerializeField] private float waitTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetPoint = 0;
    }

    

    // Update is called once per frame
    void Update()
    {
        Patrolling();
    }

    //Method for having the enemy patrol between set points in Array
    void Patrolling()
    {
        //If statement to check if we reached the desired patrolpoint, and cycles to the next point if true
        if (transform.position == patrolPoints[targetPoint].position)
        {
            IncreaseTargetInt();
            StartCoroutine("Stop");
        }
        //Makes the enemy move towards the patrol point
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[targetPoint].position, speed * Time.deltaTime);
    }

    //Method for increasing the targetpoint number and resetting back to 0 if the threshold is reached
    void IncreaseTargetInt()
    {
        targetPoint++;
        if (targetPoint >= patrolPoints.Length)
        {
            targetPoint = 0;
        }
    }

    //Coroutine for having the enemy stop on it's patrol for X amount of seconds
    public IEnumerator Stop()
    {
        speed = 0;
        yield return new WaitForSeconds(waitTime);
        speed = 4;
        yield return 0;
    }
}
