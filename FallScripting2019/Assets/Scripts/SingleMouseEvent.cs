using UnityEngine;
using UnityEngine.Events;

public class SingleMouseEvent : MonoBehaviour
{
    public UnityEvent mouseDownEvent;
    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
        mouseDownEvent.RemoveAllListeners();
    }
    
}
