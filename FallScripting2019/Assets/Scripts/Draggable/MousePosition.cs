using UnityEngine;

public class MousePosition : MonoBehaviour, IDrag
{
    public Vector3 offsetPosition { get; set; }
    public float mouseZCoordinate { get; set; }
    public Camera cam { get; set; }
    public bool Draggable { get; set; }

    protected Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mouseZCoordinate;
        return cam.ScreenToWorldPoint(mousePoint);
    }
}
