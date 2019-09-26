using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent startEvent, updateEvent, mouseDownEvent, collisionEnterEvent;
    
    private void Start()
    {
        startEvent.Invoke();
    }

    private void Update()
    {
        updateEvent.Invoke();
    }

    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }

    private void OnCollisionEnter(Collision other)
    {
       collisionEnterEvent.Invoke();
       
    }
}
