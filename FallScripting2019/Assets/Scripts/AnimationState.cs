using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationState : MonoBehaviour
{
    public bool canMove = false;
    public UnityEvent movingEvent, idleEvent;
  
    void Update()
    {
        if (canMove = true)
        {
            movingEvent.Invoke();
        }
        else if(canMove = false)
        {
            idleEvent.Invoke();
        }
        
    }
}
