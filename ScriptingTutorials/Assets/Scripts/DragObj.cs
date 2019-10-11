using UnityEngine;

public class DragObj : MonoBehaviour
{
    //Initial Script is From Tutorial
    private Vector3 mouseOffset;
    private float mouseZCoordinate;

    private void OnMouseDown()
    {
        mouseZCoordinate = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mouseOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mouseZCoordinate;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mouseOffset;
    }
}
