using UnityEngine;
using UnityEngine.Events;

public class InputEvents : MonoBehaviour
{
    public UnityEvent spaceBarEvent;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceBarEvent.Invoke();
        }
    }
}
