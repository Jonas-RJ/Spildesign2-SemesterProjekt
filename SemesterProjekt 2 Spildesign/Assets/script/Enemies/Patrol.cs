using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using UnityEditor.Experimental.GraphView;


public class Patrol : MonoBehaviour
{

    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    public Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;

        GotoNextPoint();
    }


   public void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = points[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % points.Length;

        // animator til npc bev�gelse
       
    }


    void Update()
    {
        // Choose the next destination point when the agent gets
        // close to the current one.
        PatrolToNextPoint();

        Vector3 direction3d = (agent.destination - transform.position).normalized;
        Vector2 direction = new Vector2(direction3d.x, direction3d.y);
        if (direction.magnitude >0f)
        {
            animator.SetFloat("x", transform.localScale.x);
            animator.SetFloat("y", transform.localScale.y);

            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);

        }
    }

    public void PatrolToNextPoint()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();

    }
}