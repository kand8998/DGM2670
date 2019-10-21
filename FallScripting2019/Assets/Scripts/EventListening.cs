using UnityEngine;
using UnityEngine.Events;

public class EventListening : MonoBehaviour
{
    private UnityEvent Event = new UnityEvent();
    public Object IRunObj;
    public IRun newIRunObj;

    private void Start()
    {
        newIRunObj = IRunObj as IRun;
       Event.AddListener(newIRunObj.Run);
    }
    

    private void OnDown()
    {
      Event.Invoke();
      Event.RemoveListener(newIRunObj.Run);
    }
}
