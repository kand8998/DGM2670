using System;
using UnityEngine;

public class UsingDeltaTime : MonoBehaviour
{
    //Unity Tutorial Variant;
    public float speed = 10f;
    public float countdown = 3.0f;
    public Light SpotLight;
    
   private void Update()
   {
       countdown -= Time.deltaTime;
       if (countdown <= 0.0f)
       {
           GetComponent<Light>().enabled = true;
       }

       if (Input.GetKey(KeyCode.RightArrow))
       {
           transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
       }
   }
}
