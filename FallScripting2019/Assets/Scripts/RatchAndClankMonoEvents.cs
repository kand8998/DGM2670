using UnityEngine;
using UnityEngine.Events;

public class RatchAndClankMonoEvents : MonoBehaviour
{
    public UnityEvent startEvent, triggerEnterEvent, collisionEnterEvent;
    private void Start()
    {
         startEvent.Invoke();   
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    private void OnCollisionEnter(Collision other)
    {
        collisionEnterEvent.Invoke();
    }
}
