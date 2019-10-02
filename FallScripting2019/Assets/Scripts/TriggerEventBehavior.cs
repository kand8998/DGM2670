using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
   public UnityEvent triggerEnterEvent, triggerExitEvent;
   private void OnTriggerEnter(Collider other)
   {
      triggerEnterEvent.Invoke();
   }

   private void OnTriggerExit(Collider other)
   {
      triggerExitEvent.Invoke();
   }
}
