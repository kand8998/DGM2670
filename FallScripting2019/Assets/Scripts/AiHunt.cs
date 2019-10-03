using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

//Script Based on Professor's Methods
[CreateAssetMenu(fileName = "Hunt", menuName = "Ai/Function/Hunt")]
public class AiHunt : AiBase
{
    public GameAction GameAction;
    private Transform destination;

    private void OnEnable()
    {
        GameAction.call += Call;
    }

    private void Call(object obj)
    {
        destination = obj as Transform;
    }
    
    public override void Navigate(NavMeshAgent ai)
    {
        ai.speed = Speed.Value;
        ai.angularSpeed = AngularSpeed.Value;
        ai.destination = (destination != null ? destination.position : ai.transform.position);
    }
}
