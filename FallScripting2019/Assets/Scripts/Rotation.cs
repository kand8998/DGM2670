using UnityEngine;
using UnityEngine.Events;

public class Rotation : MonoBehaviour
{
    public float forwardSpin = 35f;
    public float backSpin = -35f;
    public GameAction forwardAction, backAction;

    private void Start()
    {
        forwardAction.action = ForwardRotation;
        backAction.action = BackRotation;
    }

    public void ForwardRotation()
    {
        transform.Rotate(0,0,forwardSpin*Time.deltaTime);
    }

    public void BackRotation()
    {
        transform.Rotate(0,0,backSpin*Time.deltaTime);
    }
}