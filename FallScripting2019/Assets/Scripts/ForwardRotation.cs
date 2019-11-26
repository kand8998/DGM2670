using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardRotation : MonoBehaviour
{
    public float forwardSpin = 35f;

    public void Update()
    {
      if (Input.GetKeyDown(KeyCode.RightArrow))
      {
          transform.Rotate(0,0,forwardSpin);
      }
    }
}
