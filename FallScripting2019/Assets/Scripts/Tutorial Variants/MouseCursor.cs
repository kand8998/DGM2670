﻿using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    // Tutorial Variant
    private SpriteRenderer rend;
    public Sprite handCursor;
    public Sprite normalCursor;
    private void Start() {
        Cursor.visible = false;
        rend = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
        
        if (Input.GetMouseButtonDown(0))
        {
            rend.sprite = handCursor;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            rend.sprite = normalCursor;
        }
    }
}
