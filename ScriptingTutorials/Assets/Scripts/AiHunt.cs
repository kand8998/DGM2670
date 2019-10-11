using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

//Script Based on Professor's Script
[CreateAssetMenu(fileName = "Hunt", menuName = "Ai/Function/Hunt")]
public class AiHunt : AiBase
{
    public GameAction gameAction;
    private Transform destination;
    public object obj;

    private void OnEnable()
    {
        gameAction.action += Call;
    }
    
    private void Call()
    {
        destination = obj as Transform;
    }
    
    public override void Navigate(NavMeshAgent ai)
    {
        ai.speed = speedData.value;
        ai.angularSpeed = angularSpeed.value;
        ai.destination = (destination != null ? destination.position : ai.transform.position);
    }
}
