﻿using UnityEngine;

public class PlayerHealth : ScriptableObject, IRun
{
    public float Speed { get; set; }

    public void Run()
    {
        Debug.Log("Player Health");
    }

    public void Run(float f)
    {
        
    }
}
