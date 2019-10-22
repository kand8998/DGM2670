using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Camera))]
public class DragMoving : MonoBehaviour
{
    private Vector3 offsetPosition;
    private float mouseZCoordinate;
    public Camera cam;
    public GameAction gameActionDrag;
    void Start()
    {
        cam = Camera.main;
        gameActionDrag.action += Drag;
    }

    public void Drag()
    {
        transform.position = GetMouseWorldPos() + offsetPosition;
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mouseZCoordinate;
        return cam.ScreenToWorldPoint(mousePoint);
    }


}
