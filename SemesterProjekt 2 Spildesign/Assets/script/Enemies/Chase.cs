using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;


[RequireComponent (typeof(NavMeshAgent))]
public class Chase : MonoBehaviour
{
    public Transform Target;
    [SerializeField] private int speed;
    private NavMeshAgent mAgent;
    private float mDistance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mAgent = GetComponent<NavMeshAgent>();
        mAgent.speed = speed;
        mAgent.isStopped = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void startChase()
    {
        mDistance = Vector3.Distance(mAgent.transform.position, Target.position);
        mAgent.SetDestination(Target.position);
    }


}
