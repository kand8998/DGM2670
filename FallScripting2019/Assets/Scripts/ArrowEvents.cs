using UnityEngine;
using UnityEngine.Events;

public class ArrowEvents : MonoBehaviour
{
    public UnityEvent rightArrowDownEvent, leftArrowDownEvent, rightArrowUpEvent, leftArrowUpEvent;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightArrowDownEvent.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftArrowDownEvent.Invoke();
        }


        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rightArrowUpEvent.Invoke();
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            leftArrowUpEvent.Invoke();
        }
    }
}
