using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMoveToPoint : MonoBehaviour
{
    [SerializeField] private NavMeshAgent nma;
    [SerializeField] private Transform[] pathPoints;
    private int currentWaypointIndex = 0;
    [SerializeField] private float timeTillMove;

    void Start()
    {
        nma.SetDestination(pathPoints[currentWaypointIndex].position);
    }
    void Update()
    {
        if (!nma.pathPending && nma.remainingDistance <= nma.stoppingDistance && pathPoints != null)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= pathPoints.Length)
            {
                currentWaypointIndex = 0;
            }
            StartCoroutine(WaitToMove());
        }
    }

    IEnumerator WaitToMove()
    {
        yield return new WaitForSeconds(timeTillMove);
        if(pathPoints != null)
        {
            nma.SetDestination(pathPoints[currentWaypointIndex].position);
        }
        else
        {
            yield return null;
        }
    }
}
