using UnityEngine;
using UnityEngine.Events;

public class ArrowEvents : MonoBehaviour
{
    public UnityEvent leftArrowEvent, rightArrowEvent;
    public void Update()
    {
        while (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftArrowEvent.Invoke();
        }
        while (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightArrowEvent.Invoke();
        }
    }
}
