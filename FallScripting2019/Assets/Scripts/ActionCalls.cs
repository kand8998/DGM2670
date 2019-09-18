using System;
using UnityEngine;

public class ActionCalls : MonoBehaviour
{
    public float speed = 1f, rotateSpeed = 30f, scaleSpeed = 0.02f;
    private Vector3 location, rotations, scales;

    public enum TransformStates
    {
        Move,
        Rotate,
        Scale
    }
    public TransformStates transformState;

    private void OnMouseDown()
    {
        switch (transformState)
        {
            case TransformStates.Move:
                transformState = TransformStates.Rotate;
                break;
            case TransformStates.Rotate:
                transformState = TransformStates.Scale;
                break;
            case TransformStates.Scale:
                transformState = TransformStates.Move;
                break;
        }
    }

    private void Update() {
        switch (transformState)
        {
            case TransformStates.Move:
                OnMove();
                break;
            case TransformStates.Rotate:
                OnRotate();
                break;
            case TransformStates.Scale:
                OnScale();
                break;
        }
    }
    public void OnMove() {
        location.x = speed * Time.deltaTime;
        transform.Translate(location);
    }

    public void OnRotate() {
        rotations.y = rotateSpeed * Time.deltaTime;
        transform.Rotate(rotations);
    }

    public void OnScale(){
        scales.Set(scaleSpeed, scaleSpeed, scaleSpeed);
        transform.localScale += scales;
    }
}
