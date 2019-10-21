﻿using UnityEngine;

[CreateAssetMenu]
public class PowerUp : ScriptableObject, IRun, ITest
{
    public float Speed { get; set; }

    public void Run()
    {
        Debug.Log("Run");
    }

    public void Run(float f)
    {
        
    }

    public void Test()
    {
        Debug.Log("Test");
    }
}
