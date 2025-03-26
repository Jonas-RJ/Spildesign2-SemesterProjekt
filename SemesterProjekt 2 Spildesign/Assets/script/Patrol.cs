using JetBrains.Annotations;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Patrol : MonoBehaviour
{
    public Transform[] patrolPoints;
    public int targetPoint;
    public float speed;
    public float waitTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetPoint = 0;
    }

    

    // Update is called once per frame
    void Update()
    {
        if (transform.position == patrolPoints[targetPoint].position)
        {
            IncreaseTargetInt();
            StartCoroutine("Stop");
        }
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[targetPoint].position, speed * Time.deltaTime);
    }

    void IncreaseTargetInt()
    {
        targetPoint++;
        if (targetPoint >= patrolPoints.Length)
        {
            targetPoint = 0;
        }
    }

    public IEnumerator Stop()
    {
        speed = 0;
        yield return new WaitForSeconds(waitTime);
        speed = 4;
        yield return 0;
    }
}
