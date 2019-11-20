using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float forwardSpin = 35f;
    public float backSpin = -35f;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0,0,forwardSpin*Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0,0,backSpin*Time.deltaTime);
        }
    }
}