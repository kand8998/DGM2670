using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiClass : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform destinationObj;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.destination = destinationObj.position;
    }
}
