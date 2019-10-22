using UnityEngine;
[RequireComponent(typeof(Camera))]
public class DraggableDown : MonoBehaviour
{
    private Vector3 offsetPosition;
    private float mouseZCoordinate;
    public Camera cam;
    public bool Draggable { get; set; }
    public GameAction gameActionDown;
    private void Start()
    {
        cam = Camera.main;
        gameActionDown.action = DragOn;
    }

    private void DragOn()
    {
        Draggable = true;
        mouseZCoordinate = cam.WorldToScreenPoint(gameObject.transform.position).z;
        offsetPosition = gameObject.transform.position - GetMouseWorldPos();
    }
    
    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mouseZCoordinate;
        return cam.ScreenToWorldPoint(mousePoint);
    }
}
