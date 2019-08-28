using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
   public UnityEvent triggerEnterEvents, triggerStayEvent;
   private void OnTriggerEnter(Collider other)
   {
      triggerEnterEvents.Invoke();
   }

   public void OnTriggerStay(Collider other)
   {
      triggerStayEvent.Invoke();
   }
}
