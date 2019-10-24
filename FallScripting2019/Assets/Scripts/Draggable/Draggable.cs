using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MousePosition
{
    public GameAction Action;
    private void Start()
    {
        Action.action = MakeDraggable;
    }

    private void MakeDraggable()
    {
        Draggable = true;
        mouseZCoordinate = cam.WorldToScreenPoint(gameObject.transform.position).z;
        offsetPosition = gameObject.transform.position - GetMouseWorldPos();
    }
}
