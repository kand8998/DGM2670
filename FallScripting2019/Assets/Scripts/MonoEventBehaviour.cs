using UnityEngine;
using UnityEngine.Events;

public class MonoEventBehaviour : MonoBehaviour
{
    public UnityEvent startEvent;
    private void Start()
    {
        startEvent.Invoke();
    }
}
