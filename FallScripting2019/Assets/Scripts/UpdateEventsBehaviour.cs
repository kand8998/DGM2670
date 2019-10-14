using UnityEngine;
using UnityEngine.Events;

public class UpdateEventsBehaviour : MonoBehaviour
{
    public UnityEvent onUpdateEvent;
    void Update()
    {
        onUpdateEvent.Invoke();
    }
}
