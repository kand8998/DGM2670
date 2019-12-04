using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiClass : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform destinationObj;
    private Transform currentDestinationObj;
    public float restartTime = 3f;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        currentDestinationObj = destinationObj;
    }

    private void OnTriggerEnter(Collider other)
    {
        currentDestinationObj = transform;
        Invoke(nameof(RestartAI), restartTime);
    }

    private void RestartAI (Collider other)
    {
        currentDestinationObj = destinationObj;
    }

    private void Update()
    {
        agent.destination = currentDestinationObj.position;
    }
}
