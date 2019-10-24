using UnityEngine;

public class DragController : MonoBehaviour
{
    private Vector3 offsetPosition;
    private float mouseZCoordinate;
    private IDrag iDragger;

    public Camera cam;
    void Start()
    {
        cam = Camera.main;
    }

    public void ChangeDragger(GameAction newAction)
    {
        iDragger = newAction as IDrag;
    }
}
