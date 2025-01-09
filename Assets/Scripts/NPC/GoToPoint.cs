using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class GoToPoint : MonoBehaviour
{
    [SerializeField] GameObject endPoint;
    [SerializeField] NavMeshAgent agent;
    public UnityEvent reachEndEvent;
    private bool endReached = false;

    void Start()
    {
        agent.destination = endPoint.transform.position;
    }

    private void Update()
    {
        if (!endReached && agent.remainingDistance == 0)
        {
            endReached = true;
            reachEndEvent.Invoke();
        }
    }
}
