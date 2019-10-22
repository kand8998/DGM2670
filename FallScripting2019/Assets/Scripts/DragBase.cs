using UnityEngine;
[RequireComponent(typeof(Camera))]
public class DragBase : MonoBehaviour
{
    private Vector3 offsetPosition;
    private float mouseZCoordinate;
    
    public Camera cam;
    void Start()
    {
        cam = Camera.main;
    }
    
}
