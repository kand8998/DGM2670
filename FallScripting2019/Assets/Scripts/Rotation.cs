using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float spin = 35f;
    void Update()
    {
        transform.Rotate(0,0,spin*Time.deltaTime);
    }
}

