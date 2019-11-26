using UnityEngine;
using UnityEngine.Events;

public class RotationTransform : MonoBehaviour
{
    public float forwardSpin = 35f;
    public float backSpin = -35f;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0,0,backSpin*Time.deltaTime);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0,0,forwardSpin*Time.deltaTime);
        }
    }
}