using System;
using UnityEngine;
using UnityEngine.Events;

public class RotationAction : MonoBehaviour
{
    public float forwardSpin = 35f;
    public float backSpin = -35f;

    public GameAction forwardAction, backwardAction;

    private void Start()
    {
        forwardAction.action += ForwardRotation;
        backwardAction.action += BackwardRotation;
    }
    
    private void ForwardRotation()
    {
        transform.Rotate(0,0,forwardSpin*Time.deltaTime);
    }

    private void BackwardRotation()
    {
        transform.Rotate(0,0,backSpin*Time.deltaTime);
    }
}