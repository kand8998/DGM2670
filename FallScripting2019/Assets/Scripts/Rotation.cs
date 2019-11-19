using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float spin = 35f;

    void Update()
    {

        while (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Rotate();
        }
    }
    
    public void Rotate()
    {
        transform.Rotate(0,0,spin*Time.deltaTime);

    }
}

