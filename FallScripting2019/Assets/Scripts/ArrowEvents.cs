using System;
using UnityEngine;
using UnityEngine.Events;

public class ArrowEvents : MonoBehaviour
{
    public UnityEvent leftArrowEvent, rightArrowEvent;
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftArrowEvent.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightArrowEvent.Invoke();
        }
    }
}
