using System;
using System.ComponentModel;
using UnityEngine;

public class DragController : MonoBehaviour
{
    private Vector3 offsetPosition;
    private float mouseZCoordinate;
    public GameAction Action;

    public Camera cam;
    void Start()
    {
        cam = Camera.main;
    }

    private void OnMouseDown()
    {
        
    }
}
