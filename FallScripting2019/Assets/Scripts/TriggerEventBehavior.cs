using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
   public UnityEvent triggerEnterEvents;
   private void OnTriggerEnter(Collider other)
   {
      triggerEnterEvents.Invoke();
   }
}
